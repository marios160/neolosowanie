using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using NeoLosowanie.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCommunityPage : ContentPage
    {
        public NewCommunityPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (nameCommunity.Text.Trim().Length > 0)
            {
                Collection community = new Collection();
                community.Name = nameCommunity.Text.Trim();
                community.UserId = SystemService.User.Id;
                CollectionRepository.Insert(community);
                DisplayAlert("Sukces", "Dodano zbiór: " + community.Name, "OK");
                SystemService.SetRootPage(new LastDrawsPage());
            }
        }
    }
}