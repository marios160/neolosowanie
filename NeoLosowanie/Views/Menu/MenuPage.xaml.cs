using NeoLosowanie.Repositories;
using NeoLosowanie.Services;
using NeoLosowanie.Views.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        ViewModels.Menu.MenuPage vm;
        public MenuPage()
        {
            InitializeComponent();
            vm = new ViewModels.Menu.MenuPage();
            this.BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            if(vm.Collections.Count > 0 )
            {
                SystemService.Collection = vm.Collection = vm.Collections[0];
            }
            else
            {
                App.Current.MainPage = new NewCommunityPage();
            }
            base.OnAppearing();
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Debug.WriteLine(e.ItemIndex);
            switch (e.ItemIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    SystemService.SetRootPage(new ManagePersonsPage());
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        private void logoutButton_Tapped(object sender, EventArgs e)
        {
            SystemService.User.Logout();
            App.Current.MainPage = new LoginPage();
        }
        private void infoButton_Tapped(object sender, EventArgs e)
        {

        }
        private void donateButton_Tapped(object sender, EventArgs e)
        {

        }
        private void webButton_Tapped(object sender, EventArgs e)
        {

        }

        private void profileButton_Tapped(object sender, EventArgs e)
        {

        }
    }
}