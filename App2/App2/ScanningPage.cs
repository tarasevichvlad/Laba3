using System.Security.Cryptography.X509Certificates;
using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace App2
{
	public class ScanningPage : ZXingScannerPage
	{
		public ScanningPage()
		{
			Title = "Scanner";
			
			var page= new ZXingScannerPage();
			page.IsScanning = true;
			page.OnScanResult += Display;
			OnScanResult += Display;
		}

		public async void Display(Result result)
		{
			await DisplayAlert("Scanned result", result.Text, "OK");
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			IsScanning = true;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			IsScanning = false;
		}
	}
}