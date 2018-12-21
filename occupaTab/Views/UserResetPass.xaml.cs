using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using occupaTab.Views;

namespace occupaTab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserResetPass : ContentPage
    {
        public UserResetPass()
        {
            InitializeComponent();
        }

        public async void HandleLogin(object sender, EventArgs e)
        {
            var MainPage = new UserLogin();
            await Navigation.PushModalAsync(MainPage);
        }

    }
}
