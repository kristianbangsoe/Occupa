using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using occupaTab.Views;

namespace occupaTab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserLogin : ContentPage
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        public async void HandleLogin(object sender, EventArgs e)
        {
          
           if(EntryEmail.Text == "Admin" && EntryPassword.Text == "Admin") {
                var MainPage = new MainPage();
                await Navigation.PushModalAsync(MainPage);
            }
            else {
                await DisplayAlert("Fejl", "Forkert email eller password", "OK");
            }
        }

        public async void HandleForgotPass(object sender, EventArgs e)
        {
            var MainPage = new UserForgotPass();
            await Navigation.PushModalAsync(MainPage);
        }

    }
}


