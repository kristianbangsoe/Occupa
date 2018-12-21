using System;

using Xamarin.Forms;

namespace occupaTab.Views
{
    public class UserLogin : ContentPage
    {
        public UserLogin()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

