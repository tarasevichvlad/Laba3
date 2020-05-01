using Plugin.ContactService;
using Plugin.ContactService.Shared;
using Xamarin.Forms;

namespace App2
{
	public class ContactsPage : ContentPage
	{
		public ContactsPage()
		{
			Title = "Laboratornaya rabota 3";

			var contacts = CrossContactService.Current.GetContactListAsync().Result;

			var listView = new ListView
			{
				Header = "Contacts",
				ItemsSource = contacts
			};

			listView.ItemSelected += (sender, args) =>
			{
				Navigation.PushModalAsync(new ContactPage((sender as ListView)?.SelectedItem as Contact));
			};

			var baseLayout = new StackLayout
			{
				Children = { listView }
			};

			Content = baseLayout;
		}
	}
}