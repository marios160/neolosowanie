using NeoLosowanie.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LastDrawsPage : ContentPage
    {
        ViewModels.Pages.LastDrawsPage vm;
        public LastDrawsPage()
        {
            InitializeComponent();
            vm = new ViewModels.Pages.LastDrawsPage();
            this.BindingContext = vm;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}