using System;
using System.ComponentModel;
using System.Windows.Input;
using V4.views;
using Xamarin.Forms;

namespace V4.viewModels
{
    public class statisticsViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public ICommand settings { get; set; }
        

        public statisticsViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.settings = new Command(this.setGo);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void setGo(object obj)
        {
            Navigation.PushModalAsync(new SettingsView());
        }
    }
}

