﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Private.Infrastructure;
using Microsoft.UI.Composition;
using Microsoft.UI.Xaml.Controls;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Composition;

#if __SKIA__
[TestClass]
public class Given_ContainerVisual
{
	[TestMethod]
	[RunsOnUIThread]
	public void When_Children_Change()
	{
		var compositor = TestServices.WindowHelper.XamlRoot.Compositor;
		var containerVisual = compositor.CreateContainerVisual();
		Assert.IsFalse(containerVisual.IsChildrenRenderOrderDirty);

		var shape = compositor.CreateShapeVisual();
		containerVisual.Children.InsertAtTop(shape);
		Assert.IsTrue(containerVisual.IsChildrenRenderOrderDirty);
		var children = containerVisual.GetChildrenInRenderOrderTestingOnly();
		Assert.IsFalse(containerVisual.IsChildrenRenderOrderDirty);
		Assert.AreEqual(1, children.Count());

		containerVisual.Children.InsertAtTop(compositor.CreateShapeVisual());
		Assert.IsTrue(containerVisual.IsChildrenRenderOrderDirty);
		children = containerVisual.GetChildrenInRenderOrderTestingOnly();
		Assert.IsFalse(containerVisual.IsChildrenRenderOrderDirty);
		Assert.AreEqual(2, children.Count());

		containerVisual.Children.Remove(shape);
		Assert.IsTrue(containerVisual.IsChildrenRenderOrderDirty);
		children = containerVisual.GetChildrenInRenderOrderTestingOnly();
		Assert.IsFalse(containerVisual.IsChildrenRenderOrderDirty);
		Assert.AreEqual(1, children.Count());
	}
}
#endif