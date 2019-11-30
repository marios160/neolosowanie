using GalaSoft.MvvmLight;
using NeoLosowanie.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.ViewModels.Pages
{
    class ManagePersonsPage : ViewModelBase
    {
        public ManagePersonsPage()
        {

        }

        private bool _AddSupose;
        public bool AddSupose
        {
            get { return _AddSupose; }
            set { Set(() => AddSupose, ref _AddSupose, value); }
        }

        private List<Person> _Persons;
        public List<Person> Persons
        {
            get { return _Persons; }
            set { Set(() => Persons, ref _Persons, value); }
        }

    }
}
