using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoLosowanie.Services
{
    class DataService
    {

        public static async Task LoadData(ProgressBar progressBar)
        {
            await progressBar.ProgressTo(0.1, 100, Easing.SpringOut);
            List<Collection> list = CollectionRepository.FindAll();
            if(list.Count > 0)
                SystemService.Collection = list[0];
            else
                SystemService.Collection = null;

            await progressBar.ProgressTo(1, 900, Easing.SpringOut);
        }
    }
}
