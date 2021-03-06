﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace occupaTab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise_Psykologi_Kognitiv_ex2 : ContentPage
	{
		public Exercise_Psykologi_Kognitiv_ex2 ()
		{
			InitializeComponent ();
		}
        bool state = false;
        private async void Clicked_btn_Anatomi_Muskler_Ask_Question(object sender, EventArgs e)
        {

            var AskQuestion = new AskQuestion();
            await Navigation.PushModalAsync(AskQuestion);

        }
        private void Clicked_btn_Anatomi_Muskler_Add_as_Favorite(object sender, EventArgs e)
        {
            if (state)
            {
                state = false;
                addToFavorite.Image = "Favorite.png";
            }
            else
            {
                state = true;
                addToFavorite.Image = "Favorite_empty.png";
            }
        }

        private async void Clicked_btn_Mine_Noter(object sender, EventArgs e)
        {
            var mineNoter = new ItemsPage();
            await Navigation.PushAsync(mineNoter);
        }

        private async void Clicked_btn_Quiz(object sender, EventArgs e)
        {

            var quiz = new Quiz_Anatomi_Muskler_ex1();
            await Navigation.PushAsync(quiz);
        }
    }
}