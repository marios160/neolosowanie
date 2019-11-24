using GalaSoft.MvvmLight;
using NeoLosowanie.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NeoLosowanie.ViewModels.Pages
{
    class LastDrawsPage : ViewModelBase
    {
        public LastDrawsPage()
        {
            Items.Add(new GroupItem("TEST1", new Groups(), "12.12.2012"));
            Items.Add(new GroupItem("TEST2", new Groups(), "12.12.2012"));
            Items.Add(new GroupItem("TEST3", new Groups(), "12.12.2012"));
            Items.Add(new GroupItem("TEST4", new Groups(), "12.12.2012"));
            Items.Add(new GroupItem("TEST5", new Groups(), "12.12.2012"));
        }

        private ObservableCollection<GroupItem> _Items = new ObservableCollection<GroupItem>();
        public ObservableCollection<GroupItem> Items
        {
            get { return _Items; }
            set { Set(() => Items, ref _Items, value); }
        }

    }

    public class GroupItem
    {
        public string Title { get; set; }
        public string Groups { get; set; }
        public string CreatedAt { get; set; }

        public GroupItem(string title, Groups groups, string createdAt)
        {
            this.Title = title;
            this.Groups = groups.ToString();
            this.CreatedAt = createdAt;
        }
    }
}
