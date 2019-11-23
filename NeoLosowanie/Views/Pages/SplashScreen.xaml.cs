using NeoLosowanie.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        ViewModels.Pages.SplashScreen vm;
        public SplashScreen()
        {
            InitializeComponent();
            vm = new ViewModels.Pages.SplashScreen(progressBar);
            this.BindingContext = vm;
        }

        protected async override void OnAppearing()
        {

            await vm.LoadData();
            App.NavigationPage = new NavigationPage(new MainPage());
            RootPage rootPage = new RootPage();
            MenuPage menuPage = new MenuPage();

            rootPage.Master = menuPage;
            rootPage.Detail = App.NavigationPage;
            App.Current.MainPage = rootPage;
            base.OnAppearing();
        }
    }
}