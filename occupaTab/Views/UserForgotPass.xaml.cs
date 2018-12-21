using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using occupaTab.Views;

namespace occupaTab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserForgotPass : ContentPage
    {
        public UserForgotPass()
        {
            InitializeComponent();
        }

        public async void HandleLogin(object sender, EventArgs e)
        {
            var MainPage = new UserLogin();
            await Navigation.PushModalAsync(MainPage);
        }

        public async void HandleResetPass(object sender, EventArgs e)
        {
            var MainPage = new UserResetPass();
            await Navigation.PushModalAsync(MainPage);
        }

    }
}
