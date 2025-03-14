﻿using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.Devices.Midi;

namespace Uno.UI.RuntimeTests.Tests.Windows_Devices.Midi
{
	[TestClass]
	public class Given_MidiNoteOnMessage
	{
		[TestMethod]
		public void When_RawData()
		{
			var message = new MidiNoteOnMessage(12, 36, 17);
			var data = message.RawData.ToArray();
			CollectionAssert.AreEqual(new byte[] { 156, 36, 17 }, data);
		}

		[TestMethod]
		public void When_Channel_Out_Of_Bounds()
		{
			Assert.ThrowsExactly<ArgumentException>(
				() => new MidiNoteOnMessage(16, 10, 10));
		}

		[TestMethod]
		public void When_Note_Out_Of_Bounds()
		{
			Assert.ThrowsExactly<ArgumentException>(
				() => new MidiNoteOnMessage(12, 128, 10));
		}

		[TestMethod]
		public void When_Velocity_Out_Of_Bounds()
		{
			Assert.ThrowsExactly<ArgumentException>(
				() => new MidiNoteOnMessage(12, 10, 128));
		}
	}
}
