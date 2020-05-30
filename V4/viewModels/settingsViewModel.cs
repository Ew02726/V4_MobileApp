using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace V4.viewModels
{
    public class settingsViewModel : INotifyPropertyChanged
    {

        public settingsViewModel(INavigation navigation)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

