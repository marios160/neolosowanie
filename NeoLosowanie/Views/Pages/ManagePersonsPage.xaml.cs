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
    public partial class ManagePersonsPage : ContentPage
    {
        public ManagePersonsPage()
        {
            InitializeComponent();

            ViewModels.Pages.ManagePersonsPage vm = new ViewModels.Pages.ManagePersonsPage();
            this.BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}