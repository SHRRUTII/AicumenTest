using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AicumenTest.ViewModels
{
    /// <summary>
    /// Base ViewModel with PropertyChanged event handler
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify API when property value get change
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        protected virtual void Notify(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
