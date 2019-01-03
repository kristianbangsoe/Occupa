using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace occupaTab.Views
{
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        public async void HandleLogout(object sender, EventArgs e)
        {
            var MainPage = new UserLogin();
            await Navigation.PushModalAsync(MainPage);
        }
    }
}
