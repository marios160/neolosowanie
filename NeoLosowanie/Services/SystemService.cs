using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using NeoLosowanie.Views.Menu;
using NeoLosowanie.Views.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Xamarin.Forms;

namespace NeoLosowanie.Services
{
    class SystemService
    {
        public static User User { get; set; }
        public static Collection Collection { get; set; }
        public static void SetRootPage(Page page)
        {
            App.NavigationPage = new NavigationPage(page);
            RootPage rootPage = new RootPage();
            MenuPage menuPage = new MenuPage();

            rootPage.Master = menuPage;
            rootPage.Detail = App.NavigationPage;
            App.Current.MainPage = rootPage;

        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static ImageSource Base64ToImageSource(string base64)
        {
            return ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(base64)));
        }
    }
}
