using GalaSoft.MvvmLight;
using NeoLosowanie.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NeoLosowanie.ViewModels.Menu
{
    class MenuPage : ViewModelBase
    {
        private ObservableCollection<MenuItem> _Items = new ObservableCollection<MenuItem>();
        public ObservableCollection<MenuItem> Items
        {
            get { return _Items; }
            set { Set(() => Items, ref _Items, value); }
        }
        public MenuPage()
        {
            Items.Add(new MenuItem("Ostatnie losowania", ImageSource.FromFile("list.png"))); //dodanie nowego elementu typu MenuItem
            Items.Add(new MenuItem("Losuj", ImageSource.FromFile("random.png")));
            Items.Add(new MenuItem("Profile losowania", ImageSource.FromFile("settings.png")));
            Items.Add(new MenuItem("Zarządzanie osobami", ImageSource.FromFile("users.png")));
            if(SystemService.User != null)
                this.User = SystemService.User.Email;
        }

        private string _User;
        public string User
        {
            get { return _User; }
            set { Set(() => User, ref _User, value); }
        }
    }
    public class MenuItem
    {
        public string Title { get; set; }
        public ImageSource IconSource { get; set; }
        public MenuItem(string Title, ImageSource IconSource)
        {
            this.Title = Title;
            this.IconSource = IconSource;
        }
    }

}
