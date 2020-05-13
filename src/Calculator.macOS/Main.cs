using AppKit;
using CalculatorApp;

namespace WindowsCalculator.MacOS
{
	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();
			NSApplication.SharedApplication.MainMenu = MenuHelper.GetMenu();
			NSApplication.SharedApplication.Delegate = new App();
			NSApplication.Main(args);
		}
	}
}

