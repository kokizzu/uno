﻿#nullable enable

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Uno.UI.SourceGenerators.Helpers;
using Uno.Extensions;
using Uno.Roslyn;

namespace Uno.UI.SourceGenerators.NativeCtor
{
	[Generator]
	public class NativeCtorsGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
		{
		}

		public void Execute(GeneratorExecutionContext context)
		{
			if (PlatformHelper.IsValidPlatform(context))
			{

				var visitor = new SerializationMethodsGenerator(context);
				visitor.Visit(context.Compilation.SourceModule);
			}
		}

		private class SerializationMethodsGenerator : SymbolVisitor
		{
			private readonly GeneratorExecutionContext _context;
			private readonly INamedTypeSymbol? _iosViewSymbol;
			private readonly INamedTypeSymbol? _objcNativeHandleSymbol;
			private readonly INamedTypeSymbol? _androidViewSymbol;
			private readonly INamedTypeSymbol? _intPtrSymbol;
			private readonly INamedTypeSymbol? _jniHandleOwnershipSymbol;
			private readonly INamedTypeSymbol?[] _javaCtorParams;
			private readonly string _configuration;
			private readonly bool _isDebug;
			private readonly bool _isHotReloadEnabled;

			public SerializationMethodsGenerator(GeneratorExecutionContext context)
			{
				_context = context;

				_iosViewSymbol = context.Compilation.GetTypeByMetadataName("UIKit.UIView");
				_objcNativeHandleSymbol = context.Compilation.GetTypeByMetadataName("ObjCRuntime.NativeHandle");
				_androidViewSymbol = context.Compilation.GetTypeByMetadataName("Android.Views.View");
				_intPtrSymbol = context.Compilation.GetTypeByMetadataName("System.IntPtr");
				_jniHandleOwnershipSymbol = context.Compilation.GetTypeByMetadataName("Android.Runtime.JniHandleOwnership");
				_javaCtorParams = new[] { _intPtrSymbol, _jniHandleOwnershipSymbol };

				_configuration = context.GetMSBuildPropertyValue("Configuration")
					?? throw new InvalidOperationException("The configuration property must be provided");

				_isDebug = string.Equals(_configuration, "Debug", StringComparison.OrdinalIgnoreCase);

				if (bool.TryParse(context.GetMSBuildPropertyValue("UnoForceHotReloadCodeGen"), out var isHotReloadEnabled))
				{
					_isHotReloadEnabled = isHotReloadEnabled;
				}
				else
				{
					_isHotReloadEnabled = _isDebug;
				}
			}

			public override void VisitNamedType(INamedTypeSymbol type)
			{
				_context.CancellationToken.ThrowIfCancellationRequested();

				foreach (var t in type.GetTypeMembers())
				{
					VisitNamedType(t);
				}

				ProcessType(type);
			}

			public override void VisitModule(IModuleSymbol symbol)
			{
				_context.CancellationToken.ThrowIfCancellationRequested();

				VisitNamespace(symbol.GlobalNamespace);
			}

			public override void VisitNamespace(INamespaceSymbol symbol)
			{
				_context.CancellationToken.ThrowIfCancellationRequested();

				foreach (var n in symbol.GetNamespaceMembers())
				{
					VisitNamespace(n);
				}

				foreach (var t in symbol.GetTypeMembers())
				{
					VisitNamedType(t);
				}
			}

			private void ProcessType(INamedTypeSymbol typeSymbol)
			{
				var isiOSView = typeSymbol.Is(_iosViewSymbol);
				var isAndroidView = typeSymbol.Is(_androidViewSymbol);

				if (isiOSView)
				{
					Func<IMethodSymbol, bool> predicate = m =>
						!m.Parameters.IsDefaultOrEmpty
						&& (
							SymbolEqualityComparer.Default.Equals(m.Parameters[0].Type, _intPtrSymbol)
							|| SymbolEqualityComparer.Default.Equals(m.Parameters[0].Type, _objcNativeHandleSymbol));

					var nativeCtor = GetNativeCtor(typeSymbol, predicate, considerAllBaseTypes: false);

					if (nativeCtor == null && GetNativeCtor(typeSymbol.BaseType, predicate, considerAllBaseTypes: true) != null)
					{
						_context.AddSource(
							typeSymbol.GetFullMetadataNameForFileName(),
							GetGeneratedCode(typeSymbol));
					}
				}

				if (isAndroidView)
				{
					Func<IMethodSymbol, bool> predicate = m => m.Parameters.Select(p => p.Type).SequenceEqual(_javaCtorParams, SymbolEqualityComparer.Default);
					var nativeCtor = GetNativeCtor(typeSymbol, predicate, considerAllBaseTypes: false);

					if (nativeCtor == null && GetNativeCtor(typeSymbol.BaseType, predicate, considerAllBaseTypes: true) != null)
					{
						_context.AddSource(
							typeSymbol.GetFullMetadataNameForFileName(),
							GetGeneratedCode(typeSymbol));
					}
				}

				string GetGeneratedCode(INamedTypeSymbol typeSymbol)
				{
					var builder = new IndentedStringBuilder();
					builder.AppendLineIndented("// <auto-generated>");
					builder.AppendLineIndented("// *************************************************************");
					builder.AppendLineIndented("// This file has been generated by Uno.UI (NativeCtorsGenerator)");
					builder.AppendLineIndented("// *************************************************************");
					builder.AppendLineIndented("// </auto-generated>");
					builder.AppendLine();
					builder.AppendLineIndented("using System;");
					builder.AppendLine();

					Action<IIndentedStringBuilder> beforeClassHeaderAction = builder =>
					{
						// These will be generated just before `partial class ClassName {`
						builder.AppendLineIndented("#if __APPLE_UIKIT__ || __IOS__ || __TVOS__");

						// When C# hot reload is enabled types get replaced with a new type
						// that has a different name. We need to register the new type
						// with its original name in order to have the runtime map the
						// existing native type to the new type. native types cannot be 
						// generated at runtime

						var registerParamApple = _isHotReloadEnabled
							? $"\"{typeSymbol.GetFullMetadataName(forRegisterAttributeDotReplacement: '_')}\""
							: "";

						builder.AppendLineIndented($"[global::Foundation.Register({registerParamApple})]");

						builder.AppendLineIndented("#endif");

						if (_isHotReloadEnabled)
						{
							builder.AppendLineIndented("#if __ANDROID__");

							var registerParamAndroid = $"\"{typeSymbol.GetFullMetadataName(forRegisterAttributeDotReplacement: '/')}\"";

							builder.AppendLineIndented($"[global::Android.Runtime.Register({registerParamAndroid})]");

							builder.AppendLineIndented("#endif");
						}
					};

					using (typeSymbol.AddToIndentedStringBuilder(builder, beforeClassHeaderAction))
					{

						var syntacticValidSymbolName = SyntaxFacts.GetKeywordKind(typeSymbol.Name) == SyntaxKind.None ? typeSymbol.Name : "@" + typeSymbol.Name;

						if (NeedsExplicitDefaultCtor(typeSymbol))
						{
							builder.AppendLineIndented("/// <summary>");
							builder.AppendLineIndented("/// Initializes a new instance of the class.");
							builder.AppendLineIndented("/// </summary>");
							builder.AppendLineIndented($"public {syntacticValidSymbolName}() {{ }}");
							builder.AppendLine();
						}

						builder.Append("#if __ANDROID__");
						builder.AppendLine();
						builder.AppendLineIndented("/// <summary>");
						builder.AppendLineIndented("/// Native constructor, do not use explicitly.");
						builder.AppendLineIndented("/// </summary>");
						builder.AppendLineIndented("/// <remarks>");
						builder.AppendLineIndented("/// Used by the Xamarin Runtime to materialize native ");
						builder.AppendLineIndented("/// objects that may have been collected in the managed world.");
						builder.AppendLineIndented("/// </remarks>");
						builder.AppendLineIndented($"public {syntacticValidSymbolName}(IntPtr javaReference, global::Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer) {{ }}");
						builder.Append("#endif");
						builder.AppendLine();

						builder.Append("#if __APPLE_UIKIT__ || __IOS__ || __TVOS__ || __MACCATALYST__");
						builder.AppendLine();
						builder.AppendLineIndented("/// <summary>");
						builder.AppendLineIndented("/// Native constructor, do not use explicitly.");
						builder.AppendLineIndented("/// </summary>");
						builder.AppendLineIndented("/// <remarks>");
						builder.AppendLineIndented("/// Used by the Xamarin Runtime to materialize native ");
						builder.AppendLineIndented("/// objects that may have been collected in the managed world.");
						builder.AppendLineIndented("/// </remarks>");
						builder.AppendLineIndented($"public {syntacticValidSymbolName}(IntPtr handle) : base (handle) {{ }}");

						if (_objcNativeHandleSymbol != null)
						{
							builder.AppendLineIndented("/// <summary>");
							builder.AppendLineIndented("/// Native constructor, do not use explicitly.");
							builder.AppendLineIndented("/// </summary>");
							builder.AppendLineIndented("/// <remarks>");
							builder.AppendLineIndented("/// Used by the .NET Runtime to materialize native ");
							builder.AppendLineIndented("/// objects that may have been collected in the managed world.");
							builder.AppendLineIndented("/// </remarks>");
							builder.AppendLineIndented($"public {syntacticValidSymbolName}(global::ObjCRuntime.NativeHandle handle) : base (handle) {{ }}");
						}

						builder.Append("#endif");
						builder.AppendLine();
					}

					return builder.ToString();
				}

				static IMethodSymbol? GetNativeCtor(INamedTypeSymbol? type, Func<IMethodSymbol, bool> predicate, bool considerAllBaseTypes)
				{
					// Consider:
					// Type A -> Type B -> Type C
					// HasCtor   NoCtor    NoCtor
					// We want to generate the ctor for both Type B and Type C
					// But since the generator doesn't guarantee Type B is getting processed first,
					// We need to check the inheritance hierarchy.
					// However, assume Type B wasn't declared in source, we can't generate the ctor for it.
					// Consequently, Type C shouldn't generate source as well.
					if (type is null)
					{
						return null;
					}

					var ctor = type.GetMembers(WellKnownMemberNames.InstanceConstructorName).Cast<IMethodSymbol>().FirstOrDefault(predicate);
					if (ctor != null || !considerAllBaseTypes || !type.Locations.Any(l => l.IsInSource))
					{
						return ctor;
					}
					else
					{
						return GetNativeCtor(type.BaseType, predicate, true);
					}
				}
			}

			private static bool NeedsExplicitDefaultCtor(INamedTypeSymbol typeSymbol)
			{
				var hasExplicitConstructor = typeSymbol
					.GetMembers(WellKnownMemberNames.InstanceConstructorName)
					.Any(m => m is IMethodSymbol { IsImplicitlyDeclared: false, Parameters: { Length: 0 } });
				if (hasExplicitConstructor)
				{
					return false;
				}

				var baseHasDefaultCtor = typeSymbol
					.BaseType?
					.GetMembers(WellKnownMemberNames.InstanceConstructorName)
					.Any(m => m is IMethodSymbol { Parameters: { Length: 0 } }) ?? false;
				return baseHasDefaultCtor;
			}
		}
	}
}

