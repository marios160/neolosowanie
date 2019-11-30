using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using NeoLosowanie.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }



        private void loginButton_Clicked(object sender, EventArgs e)
        {
            User user = UserRepository.FindByEmail(login.Text);
            if (user == null)
            {
                DisplayAlert("Błąd logowania", "Podałeś błędny adres e-mail lub hasło!", "OK");
            }
            else
            {
                if (user.PasswordMD5 == SystemService.MD5Hash(password.Text))
                {
                    user.Login();
                    SystemService.User = user;
                    DisplayAlert("Zalogowano!", "Zalogowano użytkownika " + login.Text + "!", "OK");
                    App.Current.MainPage = new SplashScreen(true);
                }
                else
                {
                    DisplayAlert("Błąd logowania", "Podałeś błędny adres e-mail lub hasło!", "OK");
                }
            }
        }

        private void skipButton_Clicked(object sender, EventArgs e)
        {
            SystemService.User = new Models.User();
            SystemService.User.Id = 0;
            SystemService.User.Email = "Użytkownik niezarejestrowany";
            App.Current.MainPage = new SplashScreen(true);
        }

        private void registerButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegisterPage();
        }
    }
}