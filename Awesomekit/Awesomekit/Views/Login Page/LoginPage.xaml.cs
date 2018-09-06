using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Awesomekit.Views.LoginPage
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            //var a= ImageSource.FromResource("icon.png");
            //img.Source = a;
        }
    }
}
