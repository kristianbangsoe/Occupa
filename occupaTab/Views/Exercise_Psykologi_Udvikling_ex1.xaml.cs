using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace occupaTab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise_Psykologi_Udvikling_ex1 : ContentPage
	{
		public Exercise_Psykologi_Udvikling_ex1 ()
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

        private void Clicked_btn_Quiz(object sender, EventArgs e)
        {

            //           var quiz = new Quiz_Anatomi_Skelettet_ex2();
            //            await Navigation.PushAsync(quiz);
        }
    }
}