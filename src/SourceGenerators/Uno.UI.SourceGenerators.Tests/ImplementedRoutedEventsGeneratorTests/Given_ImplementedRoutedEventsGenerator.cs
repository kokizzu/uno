﻿using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;
using Uno.UI.SourceGenerators.ImplementedRoutedEvents;
using Uno.UI.SourceGenerators.Tests.Verifiers;

namespace Uno.UI.SourceGenerators.Tests.ImplementedRoutedEventsGeneratorTests
{
	using Verify = CSharpSourceGeneratorVerifier<ImplementedRoutedEventsGenerator>;

	[TestClass]
	public class Given_ImplementedRoutedEventsGenerator
	{
		private static readonly ReferenceAssemblies s_defaultWithUno = _Dotnet.Current.ReferenceAssemblies.AddPackages(
			ImmutableArray.Create(new PackageIdentity("Uno.WinUI", "5.0.118")));

		private async Task TestGeneratorAsync(string inputSource, params GeneratedFile[] generatedFiles)
		{
			var test = new Verify.Test
			{
				ReferenceAssemblies = s_defaultWithUno,
				TestState =
				{
					Sources = { inputSource },
				},
			};
			test.TestState.GeneratedSources.AddRange(generatedFiles.Select(f => (f.Path, f.Source)));
			await test.RunAsync();
		}

		[TestMethod]
		public async Task Given_NonGeneric_Control_In_Global_Namespace()
		{
			const string inputSource = @"
using Microsoft.UI.Xaml.Controls;

public partial class MyAwesomeControl : Control
{
}
";
			const string expectedCode = @"// <auto-generated>
partial class MyAwesomeControl
{
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	private static global::Uno.UI.Xaml.RoutedEventFlag __uno_ImplementedRoutedEvents = global::Uno.UI.Xaml.UIElementGeneratedProxy.RegisterImplementedRoutedEvents(
		typeof(MyAwesomeControl),
		global::Uno.UI.Xaml.RoutedEventFlag.None
	);
}
";
			await TestGeneratorAsync(
				inputSource,
				new GeneratedFile(
					@"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.ImplementedRoutedEvents.ImplementedRoutedEventsGenerator\MyAwesomeControl_ImplementedRoutedEvents.g.cs",
					expectedCode));
		}

		[TestMethod]
		public async Task Given_Generic_Control_In_Global_Namespace()
		{
			const string inputSource = @"
using Microsoft.UI.Xaml.Controls;

public partial class MyAwesomeControl<T> : Control
{
}
";
			const string expectedCode = @"// <auto-generated>
partial class MyAwesomeControl<T>
{
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	private static global::Uno.UI.Xaml.RoutedEventFlag __uno_ImplementedRoutedEvents = global::Uno.UI.Xaml.UIElementGeneratedProxy.RegisterImplementedRoutedEvents(
		typeof(MyAwesomeControl<T>),
		global::Uno.UI.Xaml.RoutedEventFlag.None
	);
}
";
			await TestGeneratorAsync(
				inputSource,
				new GeneratedFile(
					@"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.ImplementedRoutedEvents.ImplementedRoutedEventsGenerator\MyAwesomeControl-1_ImplementedRoutedEvents.g.cs",
					expectedCode));
		}

		[TestMethod]
		public async Task Given_Generic_Control_In_Non_Global_Namespace()
		{
			const string inputSource = @"
using Microsoft.UI.Xaml.Controls;

namespace MyControls.Test
{
	public partial class MyAwesomeControl<T> : Control
	{
	}
}
";
			const string expectedCode = @"// <auto-generated>
namespace MyControls.Test
{
	partial class MyAwesomeControl<T>
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private static global::Uno.UI.Xaml.RoutedEventFlag __uno_ImplementedRoutedEvents = global::Uno.UI.Xaml.UIElementGeneratedProxy.RegisterImplementedRoutedEvents(
			typeof(MyAwesomeControl<T>),
			global::Uno.UI.Xaml.RoutedEventFlag.None
		);
	}
}
";
			await TestGeneratorAsync(
				inputSource,
				new GeneratedFile(
					@"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.ImplementedRoutedEvents.ImplementedRoutedEventsGenerator\MyControls.Test.MyAwesomeControl-1_ImplementedRoutedEvents.g.cs",
					expectedCode));
		}
	}

	public class GeneratedFile
	{
		public GeneratedFile(string path, string source)
		{
			Path = path;
			Source = SourceText.From(source, Encoding.UTF8);
		}

		public string Path { get; set; }

		public SourceText Source { get; set; }
	}
}
