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
	public partial class Exercise_Fysiologi_Forplantning : ContentPage
	{
		public Exercise_Fysiologi_Forplantning ()
		{
			InitializeComponent ();
		}
        private async void Clicked_btn_anatomi_muskler(object sender, EventArgs e)
        {
            var Exercise_Anatomi_Muskler = new Exercise_Anatomi_Muskler();
            await Navigation.PushAsync(Exercise_Anatomi_Muskler);
        }

        private async void Clicked_btn_Fysiologi_Åndedræt(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Åndedræt = new Exercise_Fysiologi_Aandedraet();
            await Navigation.PushAsync(Exercise_Fysiologi_Åndedræt);
        }


        private async void Clicked_btn_Fysiologi_Forplantning_ex1(object sender, EventArgs e)
        {

            var Exercise_Fysiologi_Forplantning_ex1 = new Exercise_Fysiologi_Forplantning_ex1();
            await Navigation.PushAsync(Exercise_Fysiologi_Forplantning_ex1);

        }
        private async void Clicked_btn_Fysiologi_Forplantning_ex2(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Forplantningt_ex2 = new Exercise_Fysiologi_Forplantning_ex2();
            await Navigation.PushAsync(Exercise_Fysiologi_Forplantningt_ex2);

        }

        private async void Clicked_btn_Fysiologi_Forplantning(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Forplantning = new Exercise_Fysiologi_Forplantning();
            await Navigation.PushAsync(Exercise_Fysiologi_Forplantning);
        }
    }
}