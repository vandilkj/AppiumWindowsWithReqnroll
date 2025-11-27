using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumWindowsWithReqnroll.Drivers
{
	public static class WindowsSessionFactory
	{
		private const string AppiumUrl = "http://127.0.0.1:4723";

		public static WindowsDriver<WindowsElement> CreateNotepadSession()
		{
			var options = new AppiumOptions();
			options.AddAdditionalCapability("app", @"C:\Windows\System32\notepad.exe");
			options.PlatformName = "Windows";

			return new WindowsDriver<WindowsElement>(new Uri(AppiumUrl), options);
		}
	}
}