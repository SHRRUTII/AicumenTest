using AicumenTest.Interface;
using AicumenTest.UWP.DepedancyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.Web.Http;

[assembly: Xamarin.Forms.Dependency(typeof(ClearCookies))]
namespace AicumenTest.UWP.DepedancyService
{
    public class ClearCookies : IClearCookies
    {
        public async void ClearAllCookies()
        {
            await WebView.ClearTemporaryWebDataAsync();            
        }
    }
}
