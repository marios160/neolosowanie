using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoLosowanie.ViewModels.Pages
{
    class SplashScreen : ViewModelBase
    {
        ProgressBar progressBar;
        public SplashScreen(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
        }

        public async Task LoadData()
        {
            await progressBar.ProgressTo(0.1, 100, Easing.SpringOut);
            await progressBar.ProgressTo(1, 900, Easing.SpringOut);
        }
    }
}
