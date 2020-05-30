using System;
using System.Collections.Generic;
using V4.viewModels;
using Xamarin.Forms;

namespace V4.views
{
    public partial class StatisticsPage : ContentPage
    {
        public StatisticsPage()
        {
            InitializeComponent();
            BindingContext = new statisticsViewModel(this.Navigation);
        }
    }
}
