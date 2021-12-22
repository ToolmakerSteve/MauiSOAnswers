using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace MauiTests
{
	public partial class MauiAssetPage : ContentPage
	{
		public MauiAssetPage()
		{
			InitializeComponent();

			Device.BeginInvokeOnMainThread(async () =>
			{
				await InitAsync();
			});
		}

		private async Task InitAsync()
		{
			string filePath = "TestWeb.html";
#if WINDOWS
			var stream = await Microsoft.Maui.Essentials.FileSystem.OpenAppPackageFileAsync("Assets/" + filePath);
#else
			var stream = await Microsoft.Maui.Essentials.FileSystem.OpenAppPackageFileAsync(filePath);
#endif

			if (stream != null)
			{
				string s = (new System.IO.StreamReader(stream)).ReadToEnd();
				this.MyWebView.Source = new HtmlWebViewSource { Html = s };
			}
		}
	}
}