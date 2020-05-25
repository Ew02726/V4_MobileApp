using System;
using V4.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace V4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new loginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
