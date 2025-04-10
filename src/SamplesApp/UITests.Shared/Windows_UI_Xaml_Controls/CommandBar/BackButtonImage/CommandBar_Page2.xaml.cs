﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
#if __APPLE_UIKIT__
using UIKit;
using Uno.UI.Controls;
#endif
// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Windows_UI_Xaml_Controls.CommandBar.BackButtonImage
{
	public sealed partial class CommandBar_Page2 : Page
	{
		public CommandBar_Page2()
		{
			this.InitializeComponent();
		}

		public void OnButtonClicked(object sender, object args)
		{
#if __APPLE_UIKIT__
			UIView parent = this;
			while (parent.HasParent())
			{
				parent = parent.Superview;
			}

			var navigationBar = parent.FindFirstChild<UnoNavigationBar>();

			var image = (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
				? navigationBar.CompactAppearance.BackIndicatorImage
				: navigationBar.BackIndicatorImage;

			ExpectedImage.Source = image;
#endif
		}
	}
}
