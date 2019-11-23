using NeoLosowanie.Views.Menu;
using NeoLosowanie.Views.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; set; }
        public App()
        {
            InitializeComponent();
            MainPage = new SplashScreen();
            
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
