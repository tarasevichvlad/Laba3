﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App2
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabs = new TabbedPage();
			tabs.Children.Add(new NavigationPage(new TestPage()));
			tabs.Children.Add(new NavigationPage(new ContactsPage()));
			tabs.Children.Add(new NavigationPage(new FullScreenScanning()));

			MainPage = new NavigationPage(tabs);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}