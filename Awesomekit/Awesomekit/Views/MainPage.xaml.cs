﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using Awesomekit.Views.LoginPage;

namespace Awesomekit
{
    // Base view for MVVM in XLabs
    public partial class MainPage : BaseView
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            base.OnAppearing();

            // Waiting some time
            await Task.Delay(2000);

            // Start animation
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );

             Navigation.PushAsync(new LoginPage());
        }
    }
}
