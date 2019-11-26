using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using NeoLosowanie.Services;
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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void registerButton_Clicked(object sender, EventArgs e)
        {
            User user = UserRepository.FindByEmail(login.Text);
            if (user != null)
            {
                DisplayAlert("Błąd rejestracji", "Konto o podanym adresie e-mail już istnieje!", "OK");
            }
            else
            {
                if (password.Text == passwordRepeat.Text)
                {
                    user = new User(login.Text, password.Text);
                    UserRepository.Insert(user);
                    //DataService.SendEmailConfirmation(user);
                    user.Login();
                    SystemService.User = user;
                    DisplayAlert("Rejestracja", "Zarejestrowano użytkownika " +
                        SystemService.User.Email +
                        ". W wolnej chwili sprawdź skrzynkę pocztową i potwierdź adres e-mail. " +
                        "Dzięki temu będziesz mógł w przyszłości odzyskać hasło do konta.", "OK");
                    App.Current.MainPage = new SplashScreen(true);
                }
                else
                {
                    DisplayAlert("Błąd rejestracji", "Hasła się nie zgadzają!", "OK");
                }
            }
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}