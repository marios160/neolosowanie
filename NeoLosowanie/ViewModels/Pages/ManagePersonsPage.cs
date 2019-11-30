using GalaSoft.MvvmLight;
using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.ViewModels.Pages
{
    class ManagePersonsPage : ViewModelBase
    {
        public Person AddedPerson;
        public ManagePersonsPage()
        {
            AddExist = true;
            SwitchText = "Wybierz z istniejących osób";
            this.loadPersons();
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

        private bool _AddExist;
        public bool AddExist
        {
            get { return _AddExist; }
            set { Set(() => AddExist, ref _AddExist, value); }
        }

        private string _SwitchText;
        public string SwitchText
        {
            get { return _SwitchText; }
            set { Set(() => SwitchText, ref _SwitchText, value); }
        }

        private bool _AddedLabel;
        public bool AddedLabel
        {
            get { return _AddedLabel; }
            set { Set(() => AddedLabel, ref _AddedLabel, value); }
        }

        public void loadPersons()
        {
            Persons = PersonRepository.FindAllByIsMarriage(false);
        }
    }
}
