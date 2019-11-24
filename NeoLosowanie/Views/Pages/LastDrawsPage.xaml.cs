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
        public LastDrawsPage()
        {
            InitializeComponent();
            ViewModels.Pages.LastDrawsPage vm = new ViewModels.Pages.LastDrawsPage();
            this.BindingContext = vm;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}