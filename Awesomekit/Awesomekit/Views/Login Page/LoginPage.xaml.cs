using System;
using System.Collections.Generic;
using System.Windows.Input; //using TransitionNavigationPage.Enums; using Xamarin.Forms;

//using Xamarin.Forms;

namespace Awesomekit.Views.LoginPage
{
    public partial class LoginPage : ContentPage
    {
        

        public LoginPage()
        {
            
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.Flip);
            Navigation.PushAsync(new Login());

        }
    }
}
