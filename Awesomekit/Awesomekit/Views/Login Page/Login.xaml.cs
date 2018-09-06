using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Awesomekit.Views.LoginPage
{
    public partial class Login : ContentPage
    {
        public Login()
        {
        NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        void Submit_Clicked(object sender, System.EventArgs e)
        {
            var ucheck = UsernameEntry.Text;
            var pcheck = PasswordEntry.Text;

            if ((ucheck == "A" || ucheck == "a") && (pcheck == "A" || pcheck == "a"))
            {
                DisplayAlert("CORRECT", "", "OK");
            }
            else
            {
                DisplayAlert("Username or Password incorrect", "", "OK");
            }

        }
    }
}
