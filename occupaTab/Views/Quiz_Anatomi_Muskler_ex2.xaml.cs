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
	public partial class Quiz_Anatomi_Muskler_ex2 : ContentPage
	{
        Color forkert = Color.FromRgba(255, 0, 0, 0.5);
        Color rigtigt = Color.FromRgba(0, 255, 0, 0.5);

        public Quiz_Anatomi_Muskler_ex2 ()
		{
			InitializeComponent ();
		}

        private void Quiz1_A(object sender, EventArgs e)
        {
            // bool quiz1 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz1_B(object sender, EventArgs e)
        {
            // bool quiz1 = true;
            btn_Quiz1_videre.IsEnabled = true;

            Button btn = (Button)sender;
            btn.BackgroundColor = rigtigt;
            btn.BorderWidth = 1;
            btn.BorderColor = rigtigt;

        }

        private void Quiz1_C(object sender, EventArgs e)
        {
            // bool quiz1 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz1_D(object sender, EventArgs e)
        {
            //  bool quiz1 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz2_A(object sender, EventArgs e)
        {
            // bool quiz2 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz2_B(object sender, EventArgs e)
        {
            // bool quiz2 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz2_C(object sender, EventArgs e)
        {
            //  bool quiz2 = true;
            btn_Quiz2_videre.IsEnabled = true;

            Button btn = (Button)sender;
            btn.BackgroundColor = rigtigt;
            btn.BorderWidth = 1;
            btn.BorderColor = rigtigt;

        }

        private void Quiz2_D(object sender, EventArgs e)
        {
            //  bool quiz2 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz3_A(object sender, EventArgs e)
        {
            //   bool quiz3 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz3_B(object sender, EventArgs e)
        {
            //  bool quiz3 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz3_C(object sender, EventArgs e)
        {
            //  bool quiz3 = true;

            btn_Quiz3_videre.IsEnabled = true;
            Button btn = (Button)sender;
            btn.BackgroundColor = rigtigt;
            btn.BorderWidth = 1;
            btn.BorderColor = rigtigt;

        }

        private void Quiz3_D(object sender, EventArgs e)
        {
            //  bool quiz3 = false;

            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;

        }

        private void Quiz1_videre(object sender, EventArgs e)
        {

            sl_quiz1.IsVisible = false;
            sl_quiz2.IsVisible = true;
        }

        private void Quiz2_videre(object sender, EventArgs e)
        {

            sl_quiz2.IsVisible = false;
            sl_quiz3.IsVisible = true;

        }


        private void Quiz3_videre(object sender, EventArgs e)
        {

            sl_quiz_result.IsVisible = true;
            sl_quiz3.IsVisible = false;

        }
        private async void Btn_afslut(object sender, EventArgs e)
        {

            await Navigation.PopAsync();

        }
    }
}