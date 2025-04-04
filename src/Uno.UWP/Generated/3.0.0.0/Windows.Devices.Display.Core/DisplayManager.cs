// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Display.Core
{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
	[global::Uno.NotImplemented]
#endif
	public partial class DisplayManager : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		internal DisplayManager()
		{
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Display.Core.DisplayTarget> GetCurrentTargets()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<DisplayTarget> DisplayManager.GetCurrentTargets() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CDisplayTarget%3E%20DisplayManager.GetCurrentTargets%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Display.Core.DisplayAdapter> GetCurrentAdapters()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<DisplayAdapter> DisplayManager.GetCurrentAdapters() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CDisplayAdapter%3E%20DisplayManager.GetCurrentAdapters%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::Windows.Devices.Display.Core.DisplayManagerResult TryAcquireTarget(global::Windows.Devices.Display.Core.DisplayTarget target)
		{
			throw new global::System.NotImplementedException("The member DisplayManagerResult DisplayManager.TryAcquireTarget(DisplayTarget target) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayManagerResult%20DisplayManager.TryAcquireTarget%28DisplayTarget%20target%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public void ReleaseTarget(global::Windows.Devices.Display.Core.DisplayTarget target)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "void DisplayManager.ReleaseTarget(DisplayTarget target)");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::Windows.Devices.Display.Core.DisplayManagerResultWithState TryReadCurrentStateForAllTargets()
		{
			throw new global::System.NotImplementedException("The member DisplayManagerResultWithState DisplayManager.TryReadCurrentStateForAllTargets() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayManagerResultWithState%20DisplayManager.TryReadCurrentStateForAllTargets%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::Windows.Devices.Display.Core.DisplayManagerResultWithState TryAcquireTargetsAndReadCurrentState(global::System.Collections.Generic.IEnumerable<global::Windows.Devices.Display.Core.DisplayTarget> targets)
		{
			throw new global::System.NotImplementedException("The member DisplayManagerResultWithState DisplayManager.TryAcquireTargetsAndReadCurrentState(IEnumerable<DisplayTarget> targets) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayManagerResultWithState%20DisplayManager.TryAcquireTargetsAndReadCurrentState%28IEnumerable%3CDisplayTarget%3E%20targets%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::Windows.Devices.Display.Core.DisplayManagerResultWithState TryAcquireTargetsAndCreateEmptyState(global::System.Collections.Generic.IEnumerable<global::Windows.Devices.Display.Core.DisplayTarget> targets)
		{
			throw new global::System.NotImplementedException("The member DisplayManagerResultWithState DisplayManager.TryAcquireTargetsAndCreateEmptyState(IEnumerable<DisplayTarget> targets) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayManagerResultWithState%20DisplayManager.TryAcquireTargetsAndCreateEmptyState%28IEnumerable%3CDisplayTarget%3E%20targets%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::Windows.Devices.Display.Core.DisplayManagerResultWithState TryAcquireTargetsAndCreateSubstate(global::Windows.Devices.Display.Core.DisplayState existingState, global::System.Collections.Generic.IEnumerable<global::Windows.Devices.Display.Core.DisplayTarget> targets)
		{
			throw new global::System.NotImplementedException("The member DisplayManagerResultWithState DisplayManager.TryAcquireTargetsAndCreateSubstate(DisplayState existingState, IEnumerable<DisplayTarget> targets) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayManagerResultWithState%20DisplayManager.TryAcquireTargetsAndCreateSubstate%28DisplayState%20existingState%2C%20IEnumerable%3CDisplayTarget%3E%20targets%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public global::Windows.Devices.Display.Core.DisplayDevice CreateDisplayDevice(global::Windows.Devices.Display.Core.DisplayAdapter adapter)
		{
			throw new global::System.NotImplementedException("The member DisplayDevice DisplayManager.CreateDisplayDevice(DisplayAdapter adapter) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayDevice%20DisplayManager.CreateDisplayDevice%28DisplayAdapter%20adapter%29");
		}
#endif
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.Enabled.add
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.Enabled.remove
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.Disabled.add
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.Disabled.remove
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.Changed.add
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.Changed.remove
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.PathsFailedOrInvalidated.add
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManager.PathsFailedOrInvalidated.remove
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public void Start()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "void DisplayManager.Start()");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public void Stop()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "void DisplayManager.Stop()");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "void DisplayManager.Dispose()");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Devices.Display.Core.DisplayManager Create(global::Windows.Devices.Display.Core.DisplayManagerOptions options)
		{
			throw new global::System.NotImplementedException("The member DisplayManager DisplayManager.Create(DisplayManagerOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayManager%20DisplayManager.Create%28DisplayManagerOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Display.Core.DisplayManager, global::Windows.Devices.Display.Core.DisplayManagerChangedEventArgs> Changed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerChangedEventArgs> DisplayManager.Changed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerChangedEventArgs> DisplayManager.Changed");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Display.Core.DisplayManager, global::Windows.Devices.Display.Core.DisplayManagerDisabledEventArgs> Disabled
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerDisabledEventArgs> DisplayManager.Disabled");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerDisabledEventArgs> DisplayManager.Disabled");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Display.Core.DisplayManager, global::Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs> Enabled
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerEnabledEventArgs> DisplayManager.Enabled");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerEnabledEventArgs> DisplayManager.Enabled");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Display.Core.DisplayManager, global::Windows.Devices.Display.Core.DisplayManagerPathsFailedOrInvalidatedEventArgs> PathsFailedOrInvalidated
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerPathsFailedOrInvalidatedEventArgs> DisplayManager.PathsFailedOrInvalidated");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManager", "event TypedEventHandler<DisplayManager, DisplayManagerPathsFailedOrInvalidatedEventArgs> DisplayManager.PathsFailedOrInvalidated");
			}
		}
#endif
		// Processing: System.IDisposable
	}
}
