using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace App2
{
	public class TestPage : ContentPage
	{
		public TestPage()
		{
			Title = "Test QR";
			var scrolView = new ScrollView();
			var qrView = new ZXingBarcodeImageView
			{
				BarcodeFormat = BarcodeFormat.QR_CODE,
				WidthRequest = 300,
				HeightRequest = 300,
				BarcodeValue = "1337",
				BarcodeOptions = {Width = 300, Height = 300}
			};

			var stackLayout = new StackLayout
			{
				Children = { qrView }
			};

			scrolView.Content = stackLayout;

			Content = scrolView;
		}
	}
}