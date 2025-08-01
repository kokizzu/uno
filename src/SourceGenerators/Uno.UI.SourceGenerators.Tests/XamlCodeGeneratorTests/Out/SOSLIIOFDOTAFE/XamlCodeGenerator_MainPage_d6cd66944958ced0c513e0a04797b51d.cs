﻿// <autogenerated />
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers;
using Uno.UI.Helpers.Xaml;
using MyProject;

#if HAS_UNO_SKIA
using _View = Microsoft.UI.Xaml.UIElement;
#elif __ANDROID__
using _View = Android.Views.View;
#elif __APPLE_UIKIT__ || __IOS__ || __TVOS__
using _View = UIKit.UIView;
#else
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace TestRepro
{
	partial class MainPage : global::Microsoft.UI.Xaml.Controls.Page
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		private global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void InitializeComponent()
		{
			NameScope.SetNameScope(this, __nameScope);
			var __that = this;
			base.IsParsing = true;
			Resources[typeof(global::Microsoft.UI.Xaml.Controls.TextBlock)] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_1 => 
			{
				return 
					new global::Microsoft.UI.Xaml.Style
					{
						TargetType = typeof(global::Microsoft.UI.Xaml.Controls.TextBlock),
						// Source 0\MainPage.xaml (Line 7:6)
						Setters = 
						{
							new global::Microsoft.UI.Xaml.Setter
							{
								Property = global::Microsoft.UI.Xaml.Controls.TextBlock.ForegroundProperty,
								Value = new global::Microsoft.UI.Xaml.Media.SolidColorBrush(global::Microsoft.UI.Colors.Red),
								// Source 0\MainPage.xaml (Line 8:8)
							}
							,
						}
					}
					.GenericApply(__that, __nameScope, ApplyTo_Pag_ResΞ0_Sty)
				;
			}
			)
			;
			Resources["MyCustomButtonStyle"] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_1 => 
			{
				return 
					new global::Microsoft.UI.Xaml.Style
					{
						TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button),
						// Source 0\MainPage.xaml (Line 10:6)
						Setters = 
						{
							new global::Microsoft.UI.Xaml.Setter
							{
								Property = global::Microsoft.UI.Xaml.Controls.Button.BackgroundProperty,
								Value = new global::Microsoft.UI.Xaml.Media.SolidColorBrush(global::Microsoft.UI.Colors.Azure),
								// Source 0\MainPage.xaml (Line 11:8)
							}
							,
						}
					}
					.GenericApply(__that, __nameScope, ApplyTo_Pag_ResΞ1_Sty)
				;
			}
			)
			;
			Resources["MyItemTemplate"] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_1 => 
			{
				return 
					new global::Microsoft.UI.Xaml.DataTemplate(__ResourceOwner_1, Build_Pag_ResΞ2_DatTem)
					.GenericApply(__that, __nameScope, ApplyTo_Pag_ResΞ2_DatTem)
				;
			}
			)
			;
			// Source 0\MainPage.xaml (Line 1:2)
			base.Content = 
			new global::Microsoft.UI.Xaml.Controls.ListView
			{
				IsParsing = true,
				Name = "TheListView",
				HeaderTemplate = 				new global::Microsoft.UI.Xaml.DataTemplate(this, Build_PagΞ0_LisVie_HeaTemΞ0_DatTem)
				.GenericApply(__that, __nameScope, ApplyTo_PagΞ0_LisVie_HeaTemΞ0_DatTem)
				,
				// Source 0\MainPage.xaml (Line 40:4)
			}
			.GenericApply(__that, __nameScope, ApplyTo_PagΞ0_LisVie)
			;
			
			this
			.GenericApply(__that, __nameScope, ApplyTo_Pag)
			.GenericApply(__that, __nameScope, ApplyTo_Pag_Δ1)
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			((global::Microsoft.UI.Xaml.FrameworkElement)this).Loading += __UpdateBindingsAndResources;
			((global::Microsoft.UI.Xaml.FrameworkElement)this).Unloaded += __StopTracking;
		}
		partial void OnInitializeCompleted();

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_ResΞ0_Sty(global::Microsoft.UI.Xaml.Style __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L7:6");
		}



		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_ResΞ1_Sty(global::Microsoft.UI.Xaml.Style __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L10:6");
		}


		private static _View Build_Pag_ResΞ2_DatTem(object __owner, global::Microsoft.UI.Xaml.TemplateMaterializationSettings __settings)
		{
			"346ee2c4a3294fdba50b4b5daaa042583c405e7a".ToString(); // Forces this method to be updated (and use updated sub class type) when the file is being updated through Hot Reload
			return new __MainPage_d6cd66944958ced0c513e0a04797b51d.__Pag_ResΞ2_DatTem().Build(__owner, __settings);
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_ResΞ2_DatTem(global::Microsoft.UI.Xaml.DataTemplate __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L13:6");
		}

		private static _View Build_PagΞ0_LisVie_HeaTemΞ0_DatTem(object __owner, global::Microsoft.UI.Xaml.TemplateMaterializationSettings __settings)
		{
			"346ee2c4a3294fdba50b4b5daaa042583c405e7a".ToString(); // Forces this method to be updated (and use updated sub class type) when the file is being updated through Hot Reload
			return new __MainPage_d6cd66944958ced0c513e0a04797b51d.__PagΞ0_LisVie_HeaTemΞ0_DatTem().Build(__owner, __settings);
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_PagΞ0_LisVie_HeaTemΞ0_DatTem(global::Microsoft.UI.Xaml.DataTemplate __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L42:8");
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_PagΞ0_LisVie(global::Microsoft.UI.Xaml.Controls.ListView __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			/* _isTopLevelDictionary:False */
			__that._component_0 = __p1;
			__nameScope.RegisterName("TheListView", __p1);
			__that.TheListView = __p1;
			global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(__p1, global::Microsoft.UI.Xaml.Controls.ListView.ItemTemplateProperty, "MyItemTemplate", isThemeResourceExtension: false, isHotReloadSupported: true, context: global::MyProject.GlobalStaticResources.__ParseContext_);
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 40, 4);
			__p1.CreationComplete();
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag(global::Microsoft.UI.Xaml.Controls.Page __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			// Source 0\MainPage.xaml (Line 1:2)
			
			// WARNING Property __p1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_Δ1(global::Microsoft.UI.Xaml.Controls.Page __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			/* _isTopLevelDictionary:False */
			__that._component_1 = __p1;
			// Class TestRepro.MainPage
			global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(__p1, global::Microsoft.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: true, context: global::MyProject.GlobalStaticResources.__ParseContext_);
			global::Microsoft.UI.Xaml.VisualStateManager.SetVisualStateGroups(__p1, 
			new[]
			{
				new global::Microsoft.UI.Xaml.VisualStateGroup
				{
					// Source 0\MainPage.xaml (Line 21:6)
					States = 
					{
						new global::Microsoft.UI.Xaml.VisualState
						{
							Name = "WideState",
							StateTriggers = 
							{
								new global::Microsoft.UI.Xaml.AdaptiveTrigger
								{
									MinWindowWidth = 641d,
									// Source 0\MainPage.xaml (Line 24:12)
								}
								.GenericApply(__that, __nameScope, ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ0_VisSta_StaTriΞ0_AdaTri)
								,
							}
							,
							// Source 0\MainPage.xaml (Line 22:8)
						}
						.GenericApply(__that, __nameScope, ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ0_VisSta)
						,
						new global::Microsoft.UI.Xaml.VisualState
						{
							Name = "NarrowState",
							StateTriggers = 
							{
								new global::Microsoft.UI.Xaml.AdaptiveTrigger
								{
									MinWindowWidth = 0d,
									// Source 0\MainPage.xaml (Line 32:12)
								}
								.GenericApply(__that, __nameScope, ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ1_VisSta_StaTriΞ0_AdaTri)
								,
							}
							,
							// Source 0\MainPage.xaml (Line 30:8)
						}
						.GenericApply(__that, __nameScope, ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ1_VisSta)
						,
					}
				}
				,	}
			);
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 1, 2);
			__p1.CreationComplete();
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ0_VisSta_StaTriΞ0_AdaTri(global::Microsoft.UI.Xaml.AdaptiveTrigger __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L24:12");
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ0_VisSta(global::Microsoft.UI.Xaml.VisualState __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			__nameScope.RegisterName("WideState", __p1);
			__that.WideState = __p1;
			global::Uno.UI.Helpers.MarkupHelper.SetVisualStateLazy(__p1, () => 
			{
				__p1.Name = "WideState";
				__p1.Setters.Add(
					new global::Microsoft.UI.Xaml.Setter
					{
						Target = new global::Microsoft.UI.Xaml.TargetPropertyPath(this._TheListViewSubject, "Background"),
						Value = @"Red",
						// Source 0\MainPage.xaml (Line 27:12)
					}
				);
				;
			}
			);
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L22:8");
		}


		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ1_VisSta_StaTriΞ0_AdaTri(global::Microsoft.UI.Xaml.AdaptiveTrigger __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L32:12");
		}

		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		private void ApplyTo_Pag_VisStaGroΞ0_VisStaGroΞ1_VisSta(global::Microsoft.UI.Xaml.VisualState __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
		{
			__nameScope.RegisterName("NarrowState", __p1);
			__that.NarrowState = __p1;
			global::Uno.UI.Helpers.MarkupHelper.SetVisualStateLazy(__p1, () => 
			{
				__p1.Name = "NarrowState";
				__p1.Setters.Add(
					new global::Microsoft.UI.Xaml.Setter
					{
						Target = new global::Microsoft.UI.Xaml.TargetPropertyPath(this._TheListViewSubject, "Background"),
						Value = @"Green",
						// Source 0\MainPage.xaml (Line 35:12)
					}
				);
				;
			}
			);
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__p1, "OriginalSourceLocation", "file:///C:/Project/0/MainPage.xaml#L30:8");
		}


		private void __UpdateBindingsAndResources(global::Microsoft.UI.Xaml.FrameworkElement s, object e)
		{
			this.Bindings.UpdateResources();
		}

		private void __StopTracking(object s, global::Microsoft.UI.Xaml.RoutedEventArgs e)
		{
			this.Bindings.StopTracking();
		}

		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _NarrowStateSubjectBackingPseudoField { get; set; }
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _NarrowStateSubject
		{
			get => _NarrowStateSubjectBackingPseudoField ??= new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		}
		private global::Microsoft.UI.Xaml.VisualState NarrowState
		{
			get => (global::Microsoft.UI.Xaml.VisualState)_NarrowStateSubject.ElementInstance;
			set => _NarrowStateSubject.ElementInstance = value;
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _TheListViewSubjectBackingPseudoField { get; set; }
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _TheListViewSubject
		{
			get => _TheListViewSubjectBackingPseudoField ??= new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		}
		private global::Microsoft.UI.Xaml.Controls.ListView TheListView
		{
			get => (global::Microsoft.UI.Xaml.Controls.ListView)_TheListViewSubject.ElementInstance;
			set => _TheListViewSubject.ElementInstance = value;
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _WideStateSubjectBackingPseudoField { get; set; }
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _WideStateSubject
		{
			get => _WideStateSubjectBackingPseudoField ??= new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		}
		private global::Microsoft.UI.Xaml.VisualState WideState
		{
			get => (global::Microsoft.UI.Xaml.VisualState)_WideStateSubject.ElementInstance;
			set => _WideStateSubject.ElementInstance = value;
		}
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdate]
		private class __MainPage_d6cd66944958ced0c513e0a04797b51d
		{
			[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
			[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
			[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			[global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdate]
			public class __Pag_ResΞ2_DatTem
			{
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
				global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
				global::System.Object __ResourceOwner_1;
				_View __rootInstance = null;
				public _View Build(object __ResourceOwner_1, global::Microsoft.UI.Xaml.TemplateMaterializationSettings __settings)
				{
					var __that = this;
					this.__ResourceOwner_1 = __ResourceOwner_1;
					this.__rootInstance = 
					new global::Microsoft.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true,
						// Source 0\MainPage.xaml (Line 14:8)
						Children = 
						{
							new global::Microsoft.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true,
								// Source 0\MainPage.xaml (Line 15:10)
							}
							.GenericApply(__that, __nameScope, ApplyTo_Ξ0_StaPanΞ0_TexBlo)
							,
							new global::Microsoft.UI.Xaml.Controls.Button
							{
								IsParsing = true,
								Content = @"DoSomething",
								// Source 0\MainPage.xaml (Line 16:10)
							}
							.GenericApply(__that, __nameScope, ApplyTo_Ξ0_StaPanΞ1_But)
							,
						}
					}
					.GenericApply(__that, __nameScope, ApplyTo_Ξ0_StaPan)
					;
					if (__rootInstance is FrameworkElement __fe)
					{
						__fe.Loading += __UpdateBindingsAndResources;
						__fe.Unloaded += __StopTracking;
					}
					if (__rootInstance is DependencyObject d)
					{
						if (global::Microsoft.UI.Xaml.NameScope.GetNameScope(d) == null)
						{
							global::Microsoft.UI.Xaml.NameScope.SetNameScope(d, __nameScope);
							__nameScope.Owner = d;
						}
						global::Uno.UI.FrameworkElementHelper.AddObjectReference(d, this);
					}
					return __rootInstance;
				}
					private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_HolderBackingPseudoField { get; set; }
					private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_Holder
					{
						get => _component_0_HolderBackingPseudoField ??= new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: true);
					}
					private global::Microsoft.UI.Xaml.Controls.Button _component_0
					{
						get => (global::Microsoft.UI.Xaml.Controls.Button)_component_0_Holder.Instance;
						set => _component_0_Holder.Instance = value;
					}
					
				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
				private void ApplyTo_Ξ0_StaPanΞ0_TexBlo(global::Microsoft.UI.Xaml.Controls.TextBlock __p1, __Pag_ResΞ2_DatTem __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
				{
					__p1.SetBinding(
						global::Microsoft.UI.Xaml.Controls.TextBlock.TextProperty,
						new Microsoft.UI.Xaml.Data.Binding()
						{
							Path = @"",
						}
					);
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 15, 10);
					__p1.CreationComplete();
				}

				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
				private void ApplyTo_Ξ0_StaPanΞ1_But(global::Microsoft.UI.Xaml.Controls.Button __p1, __Pag_ResΞ2_DatTem __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
				{
					/* _isTopLevelDictionary:False */
					__that._component_0 = __p1;
					global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(__p1, global::Microsoft.UI.Xaml.Controls.Button.StyleProperty, "MyCustomButtonStyle", isThemeResourceExtension: false, isHotReloadSupported: true, context: global::MyProject.GlobalStaticResources.__ParseContext_);
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 16, 10);
					__p1.CreationComplete();
				}

				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
				private void ApplyTo_Ξ0_StaPan(global::Microsoft.UI.Xaml.Controls.StackPanel __p1, __Pag_ResΞ2_DatTem __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
				{
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 14, 8);
					__p1.CreationComplete();
				}

				private void __UpdateBindingsAndResources(global::Microsoft.UI.Xaml.FrameworkElement s, object e)
				{
					_component_0.UpdateResourceBindings();
				}

				private void __StopTracking(object s, global::Microsoft.UI.Xaml.RoutedEventArgs e)
				{
				}

			}
			[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
			[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
			[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			[global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdate]
			public class __PagΞ0_LisVie_HeaTemΞ0_DatTem
			{
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
				global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
				global::System.Object __ResourceOwner_1;
				_View __rootInstance = null;
				public _View Build(object __ResourceOwner_1, global::Microsoft.UI.Xaml.TemplateMaterializationSettings __settings)
				{
					var __that = this;
					this.__ResourceOwner_1 = __ResourceOwner_1;
					this.__rootInstance = 
					new global::Microsoft.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						Text = "Header",
						// Source 0\MainPage.xaml (Line 43:10)
					}
					.GenericApply(__that, __nameScope, ApplyTo_Ξ0_TexBlo)
					;
					if (__rootInstance is DependencyObject d)
					{
						if (global::Microsoft.UI.Xaml.NameScope.GetNameScope(d) == null)
						{
							global::Microsoft.UI.Xaml.NameScope.SetNameScope(d, __nameScope);
							__nameScope.Owner = d;
						}
						global::Uno.UI.FrameworkElementHelper.AddObjectReference(d, this);
					}
					return __rootInstance;
				}
				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
				[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
				private void ApplyTo_Ξ0_TexBlo(global::Microsoft.UI.Xaml.Controls.TextBlock __p1, __PagΞ0_LisVie_HeaTemΞ0_DatTem __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
				{
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 43, 10);
					__p1.CreationComplete();
				}

			}
		}
			private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_HolderBackingPseudoField { get; set; }
			private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_Holder
			{
				get => _component_0_HolderBackingPseudoField ??= new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: true);
			}
			private global::Microsoft.UI.Xaml.Controls.ListView _component_0
			{
				get => (global::Microsoft.UI.Xaml.Controls.ListView)_component_0_Holder.Instance;
				set => _component_0_Holder.Instance = value;
			}
			
			private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_1_HolderBackingPseudoField { get; set; }
			private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_1_Holder
			{
				get => _component_1_HolderBackingPseudoField ??= new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: true);
			}
			private global::Microsoft.UI.Xaml.Controls.Page _component_1
			{
				get => (global::Microsoft.UI.Xaml.Controls.Page)_component_1_Holder.Instance;
				set => _component_1_Holder.Instance = value;
			}
			
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
			void NotifyXLoad(string name);
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Generated code")]
		[global::System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Generated code")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::TestRepro.MainPage Owner { get => (global::TestRepro.MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::TestRepro.MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(global::TestRepro.MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.NotifyXLoad(string name)
			{
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IMainPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
				owner._component_1.UpdateResourceBindings();
			}
			void IMainPage_Bindings.StopTracking()
			{
				var owner = Owner;
			}
		}
	}
}
