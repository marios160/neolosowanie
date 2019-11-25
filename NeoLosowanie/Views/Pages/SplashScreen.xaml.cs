using NeoLosowanie.Repositories;
using NeoLosowanie.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        private bool Skip { get; set; }
        public SplashScreen(bool skip = false)
        {
            Skip = skip;
            InitializeComponent();
            DataBase db = new DataBase();
        }

        protected async override void OnAppearing()
        {
            if (Skip)
            {
                await DataService.LoadData(this.progressBar);
                SystemService.SetRootPage(new LastDrawsPage());
            }
            else
            {

                SystemService.User = UserRepository.FindByIsLogged();
                if (SystemService.User == null)
                {
                    App.Current.MainPage = new LoginPage();
                }
                else
                {
                    await DataService.LoadData(this.progressBar);
                    SystemService.SetRootPage(new LastDrawsPage());
                }
            }
            base.OnAppearing();
        }
    }
}