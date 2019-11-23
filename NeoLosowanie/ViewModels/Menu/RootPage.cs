using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.ViewModels.Menu
{
    class RootPage : ViewModelBase
    {
        public RootPage()
        {

        }

        private bool _IsPresented;
        public bool IsPresented
        {
            get { return _IsPresented; }
            set { Set(() => IsPresented, ref _IsPresented, value); }
        }
    }
}
