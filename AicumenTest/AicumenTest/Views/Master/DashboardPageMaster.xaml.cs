using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AicumenTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPageMaster : ContentPage
    {
        public ListView ListView;

        public DashboardPageMaster()
        {
            InitializeComponent();

            //BindingContext = new DashboardPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        //class DashboardPageMasterViewModel : INotifyPropertyChanged
        //{
            
            
        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}
    }
}