using AicumenTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AicumenTest
{
	public partial class App : Application
	{
        string accessToken = string.Empty;
        public IFileEngine fileEngine = DependencyService.Get<IFileEngine>();
        public App ()
		{
			InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected async override void OnStart()
        {
            // Handle when your app starts    
            IEnumerable<string> collection = await fileEngine.GetFilesAsync();
            if (collection.Contains("AccessToken"))
            {
                accessToken = await fileEngine.ReadTextAsync("AccessToken");
            }

            //User already login then navigate to Dashboard
            if (string.IsNullOrEmpty(accessToken))
                MainPage = new NavigationPage(new MainPage());
            else
                MainPage = new NavigationPage(new DashboardPage());
        }
        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
