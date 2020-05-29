using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace V4.viewModels
{
    public class loginViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation {get; set;}
        public ICommand login { get; set; }

        public loginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.login = new Command(this.loginToDash);
        }

        private void loginToDash(object obj)
        {
            Application.Current.MainPage = new AppShell2();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

