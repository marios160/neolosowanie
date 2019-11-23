using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            ViewModels.Menu.RootPage vm = new ViewModels.Menu.RootPage();
            this.BindingContext = vm;
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}