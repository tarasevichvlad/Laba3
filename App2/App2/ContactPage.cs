using Plugin.ContactService.Shared;
using Xamarin.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Net.Mobile.Forms;

namespace App2
{
	public class ContactPage : ContentPage
	{
		public ContactPage(Contact contact)
		{
			Init(contact);
		}

		private void Init(Contact contact)
		{
			var qrView = new ZXingBarcodeImageView
			{
				BarcodeValue = $"{contact.Name}, {contact.Number}",
				BarcodeFormat = BarcodeFormat.QR_CODE,
				WidthRequest = 300,
				HeightRequest = 300,
				BarcodeOptions = new EncodingOptions
				{
					Height = 300,
					Width = 300
				}
			};

			var name = new Entry();
			name.Text = contact.Name; // SetBinding(Entry.TextProperty, contact.Name);

			var number = new Entry
			{
				Text = contact.Number
			};
			// SetBinding(Entry.TextProperty, contact.Number ?? "");

			var cancelButton = new Button
			{
				Text = "Cancel"
			};

			cancelButton.Clicked += (sender, args) =>
			{
				Navigation.PopModalAsync();
			};

			var stackLayout = new StackLayout
			{
				Children = { qrView, name, number, cancelButton }
			};

			Content = stackLayout;
		}
	}
}