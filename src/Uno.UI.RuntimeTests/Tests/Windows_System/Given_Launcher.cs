﻿#if __ANDROID__ || __APPLE_UIKIT__
using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.ApplicationModel.Core;
using Windows.System;
using Windows.UI.Core;

namespace Uno.UI.RuntimeTests.Tests.Windows_System
{

	[TestClass]
	public class Given_Launcher
	{
		[TestMethod]
		public async Task When_Null_Uri_Is_Launched()
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => Launcher.LaunchUriAsync(null).AsTask());
		}

		[TestMethod]
		public async Task When_Null_Uri_Is_Queried()
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => Launcher.QueryUriSupportAsync(null, LaunchQuerySupportType.Uri).AsTask());
		}

		[TestMethod]
		public async Task When_Valid_Uri_Is_Queried()
		{
			var result = await Launcher.QueryUriSupportAsync(
				new Uri("https://platform.uno"),
				LaunchQuerySupportType.Uri);

			Assert.AreEqual(LaunchQuerySupportStatus.Available, result);
		}

		[TestMethod]
		public async Task When_Unsupported_Uri_Is_Queried()
		{
			var result = await Launcher.QueryUriSupportAsync(
				new Uri("thisschemedefinitelydoesnotexist://helloworld"),
				LaunchQuerySupportType.Uri);

			Assert.AreEqual(LaunchQuerySupportStatus.NotSupported, result);
		}

		[TestMethod]
		public async Task When_Settings_Uri_Is_Queried()
		{
			var result = await Launcher.QueryUriSupportAsync(
				new Uri("ms-settings:network-wifi"),
				LaunchQuerySupportType.Uri);

			Assert.AreEqual(LaunchQuerySupportStatus.Available, result);
		}

		[TestMethod]
		public async Task When_Unsupported_Special_Uri_Is_Queried()
		{
			var result = await Launcher.QueryUriSupportAsync(
				new Uri("ms-windows-store://home"),
				LaunchQuerySupportType.Uri);

			Assert.AreEqual(LaunchQuerySupportStatus.NotSupported, result);
		}

		private async Task DispatchAsync(Func<Task> asyncAction)
		{
			var completionSource = new TaskCompletionSource<object>();

			await CoreApplication.GetCurrentView().Dispatcher
				.RunAsync(CoreDispatcherPriority.Normal, async () =>
				{
					try
					{
						await asyncAction();
					}
					finally
					{
						completionSource.SetResult(null);
					}
				});

			await completionSource.Task;
		}
	}
}
#endif
