using System;
using System.Collections.Generic;
using V4.viewModels;
using Xamarin.Forms;

namespace V4.views
{
    public partial class loginPage : ContentPage
    {
        public loginPage()
        {
            InitializeComponent();

            BindingContext = new loginViewModel(this.Navigation);
        }

       
    }
}
