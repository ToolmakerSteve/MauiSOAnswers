using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiTests
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new MainPage();
			//MainPage = new TapContentPage();
			//MainPage = new FrameWithHeaderLabelPage();
			//MainPage = new MauiAssetPage();
			MainPage = new Login();
		}
	}
}
