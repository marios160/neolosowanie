﻿using GalaSoft.MvvmLight;
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
            Items.Add(new MenuItem("Home", ImageSource.FromResource("FirstXamarinApp.Home.png"))); //dodanie nowego elementu typu MenuItem
            Items.Add(new MenuItem("Page2", ImageSource.FromResource("FirstXamarinApp.Home.png")));
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