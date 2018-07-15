using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AicumenTest.ViewModels
{
    /// <summary>
    /// Dashboard Master ViewModel
    /// </summary>
    public class DashboardPageMasterViewModel:BaseViewModel
    {
        public ObservableCollection<DashboardPageMenuItem> MenuItems { get; set; }

        public DashboardPageMasterViewModel()
        {
            //Hamburger menu links
            MenuItems = new ObservableCollection<DashboardPageMenuItem>(new[]
            {
                    new DashboardPageMenuItem { Id = 0, Title = "Top 10 Cryptos", TargetType = typeof(TopCryptoList) },
                    new DashboardPageMenuItem { Id = 1, Title = "Pie Chart" , TargetType = typeof(MicroChartPage) },
                    new DashboardPageMenuItem { Id = 2, Title = "Sign out"},
                });
        }
    }
}
