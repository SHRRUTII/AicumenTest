using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using AicumenTest.Interface;
using AicumenTest.iOS.DepedancyService;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(ClearCookies))]
namespace AicumenTest.iOS.DepedancyService
{
    public class ClearCookies : IClearCookies
    {
        public void ClearAllCookies()
        {
            NSHttpCookieStorage CookieStorage = NSHttpCookieStorage.SharedStorage;
            foreach (var cookie in CookieStorage.Cookies)
                CookieStorage.DeleteCookie(cookie);
        }
    }
}