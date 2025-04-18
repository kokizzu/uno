﻿using System;

namespace Uno.UI.Xaml.Controls;

internal partial class NativeWindowWrapper : NativeWindowWrapperBase, INativeWindowWrapper
{
	private static readonly Lazy<NativeWindowWrapper> _instance = new(() => new NativeWindowWrapper());

	internal static NativeWindowWrapper Instance => _instance.Value;

	public override object NativeWindow => null;
}
