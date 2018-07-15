using AicumenTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AicumenTest
{
	public partial class MainPage : ContentPage
	{
        /// <summary>
        /// Get a new ClientId from:
        /// https://developers.facebook.com/apps/
        /// </summary>
        private string ClientId = "476315046161127";
        private string accessToken = string.Empty;
        public IFileEngine fileEngine = DependencyService.Get<IFileEngine>();
        public MainPage()
		{
			InitializeComponent();
            Content = MainLayout;
        }
        private async void OnFBLoginClicked(object sender, EventArgs args)
        {
            var apiRequest = "https://www.facebook.com/dialog/oauth?client_id="
                + ClientId
                + "&display=popup&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";
            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebViewOnNavigated;
            Content = webView;            
        }
        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAccessTokenFromUrl(e.Url);
             if(accessToken != "")
            {
                //Persist Access Token into file
                await fileEngine.WriteTextAsync("AccessToken", accessToken);
                await NavigateToDashboard();
            }
        }

        private async Task NavigateToDashboard()
        {
            if (App.Current.MainPage is NavigationPage)
                await(App.Current.MainPage as NavigationPage).PushAsync(new DashboardPage());
        }
        private string ExtractAccessTokenFromUrl(string url)
        {
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");
                if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
                {
                    at = url.Replace("http://www.facebook.com/connect/login_success.html#access_token=", "");
                }
                var accessToken = at.Remove(at.IndexOf("&expires_in="));
                return accessToken;
            }
            return string.Empty;
        }
    }
}
