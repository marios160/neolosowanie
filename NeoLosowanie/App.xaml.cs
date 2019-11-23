using NeoLosowanie.Views.Menu;
using NeoLosowanie.Views.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }
        public App()
        {
            InitializeComponent();

            NavigationPage = new NavigationPage(new MainPage());
            RootPage rootPage = new RootPage();
            MenuPage menuPage = new MenuPage();

            rootPage.Master = menuPage;
            rootPage.Detail = NavigationPage;
            MainPage = rootPage;
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
