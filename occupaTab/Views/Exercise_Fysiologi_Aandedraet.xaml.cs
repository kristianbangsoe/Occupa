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
	public partial class Exercise_Fysiologi_Aandedraet : ContentPage
	{
		public Exercise_Fysiologi_Aandedraet ()
		{
			InitializeComponent ();
		}
      
        private async void Clicked_btn_Fysiologi_Åndedræt(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Åndedræt = new Exercise_Fysiologi_Aandedraet();
            await Navigation.PushAsync(Exercise_Fysiologi_Åndedræt);
        }

        private async void Clicked_btn_Fysiologi_Forplantning(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Forplantning = new Exercise_Fysiologi_Forplantning();
            await Navigation.PushAsync(Exercise_Fysiologi_Forplantning);
        }

        private async void Clicked_btn_Fysiologi_Åndedræt_ex1(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Åndedræt_ex1 = new Exercise_Fysiologi_Aandedraet_ex1();
            await Navigation.PushAsync(Exercise_Fysiologi_Åndedræt_ex1);

        }
        private async void Clicked_btn_Fysiologi_Åndedræt_ex2(object sender, EventArgs e)
        {
            var Exercise_Fysiologi_Åndedræt_ex2 = new Exercise_Fysiologi_Aandedraet_ex2();
            await Navigation.PushAsync(Exercise_Fysiologi_Åndedræt_ex2);
        }               
    }
}