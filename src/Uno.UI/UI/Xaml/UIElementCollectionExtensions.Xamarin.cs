﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UI.Xaml.Media;
#if __ANDROID__
using _View = Android.Views.View;
#elif __APPLE_UIKIT__
using _View = UIKit.UIView;
#endif

namespace Microsoft.UI.Xaml.Controls
{
	public static class UIElementCollectionExtensions
	{
		/// <summary>
		/// Add a native view to a <see cref="UIElementCollection"/>. It will be wrapped in a <see cref="FrameworkElement"/>-derived container to satisfy the type constraints of <see cref="UIElementCollection"/>.
		/// </summary>
		/// <remarks>This method is present to support collection initializer syntax for native views.</remarks>
		public static void Add(this UIElementCollection uiElementCollection, _View view)
		{
			if (uiElementCollection is null)
			{
				throw new ArgumentNullException(nameof(uiElementCollection));
			}

			if (view is UIElement uiElement)
			{
				uiElementCollection.Add(uiElement);
			}
			else
			{
				var wrapper = VisualTreeHelper.AdaptNative(view);
				uiElementCollection.Add(wrapper);
			}
		}
	}
}
