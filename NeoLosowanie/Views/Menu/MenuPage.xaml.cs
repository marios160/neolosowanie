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
        public MenuPage()
        {
            InitializeComponent();
            ViewModels.Menu.MenuPage vm = new ViewModels.Menu.MenuPage();
            this.BindingContext = vm;
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
                    SetRootPage(new ManagePersonsPage());
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        public static void SetRootPage(Page page)
        {
            App.NavigationPage = new NavigationPage(page);
            RootPage rootPage = new RootPage();
            MenuPage menuPage = new MenuPage();

            rootPage.Master = menuPage;
            rootPage.Detail = App.NavigationPage;
            App.Current.MainPage = rootPage;
        }
    }
}