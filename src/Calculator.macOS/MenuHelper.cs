using System;
using AppKit;

namespace WindowsCalculator.MacOS
{
	public static class MenuHelper
	{
		internal static NSMenu GetMenu()
		{
			var menubar = new NSMenu();
			var appMenuItem = new NSMenuItem();
			menubar.AddItem(appMenuItem);

			var appMenu = new NSMenu();

			//TODO: Get from string resources
			var quitTitle = "Quit";
			var quitMenuItem = new NSMenuItem(quitTitle, "q", delegate {
				NSApplication.SharedApplication.Terminate(menubar);
			});

			appMenu.AddItem(quitMenuItem);
			appMenuItem.Submenu = appMenu;

			return menubar;
		}
	}
}
