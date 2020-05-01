using System;
using System.Linq;
using Plugin.ContactService.Shared;
using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace App2
{
	public partial class FullScreenScanning : ZXingScannerPage
	{
		public FullScreenScanning()
		{
			InitializeComponent();
		}

		public void Handle_OnScanResult(Result result)
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				var items = result.Text.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

				var contact = new Contact { Name = items.First(), Number = items.Last() };

				await Navigation.PushModalAsync(new ContactPage(contact));
				// await DisplayAlert("Scanned result", result.Text, "OK");
			});
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