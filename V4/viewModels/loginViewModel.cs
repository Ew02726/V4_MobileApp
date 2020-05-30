using System;
using System.ComponentModel;
using System.Windows.Input;
using V4.views;
using Xamarin.Forms;

namespace V4.viewModels
{
    public class loginViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation {get; set;}
        public ICommand login { get; set; }
        public ICommand forgotPassword { get; set; }
        public ICommand createAccount { get; set; }

        public loginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.login = new Command(this.loginToDash);
            this.forgotPassword = new Command(this.forgotPasswrd);
            this.createAccount = new Command(this.createAccountPage);
        }

        private void loginToDash(object obj)
        {
            Application.Current.MainPage = new AppShell2();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void forgotPasswrd(object obj)
        {
            Navigation.PushModalAsync(new DashPage());
        }

        private void createAccountPage(object obj)
        {
            //Navigation.PushAsync(new SettingsView());
            Shell.Current.Navigation.PushAsync(new SettingsView());
        }
    }
}

