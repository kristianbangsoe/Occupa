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
	public partial class Exercise_Anatomi_Muskler : ContentPage
	{
		public Exercise_Anatomi_Muskler()
		{
			InitializeComponent ();
		}
        
        private async void Clicked_btn_anatomi_muskler(object sender, EventArgs e)
        {
            var Exercise_Anatomi_Muskler = new Exercise_Anatomi_Muskler();
            await Navigation.PushAsync(Exercise_Anatomi_Muskler);
        }

        private async void Clicked_btn_anatomi_skelettet(object sender, EventArgs e)
        {
            var Exercise_Anatomi_Skelettet = new Exercise_Anatomi_Skelettet();
            await Navigation.PushAsync(Exercise_Anatomi_Skelettet);
        }

   
        private async void Clicked_btn_anatomi_muskler_ex1(object sender, EventArgs e)
        {

            var Exercise_Anatomi_Muskler_ex1 = new Exercise_Anatomi_Muskler_ex1();
            await Navigation.PushAsync(Exercise_Anatomi_Muskler_ex1);

        }
        private async void Clicked_btn_anatomi_muskler_ex2(object sender, EventArgs e)
        {
            var Exercise_Anatomi_Muskler_ex2 = new Exercise_Anatomi_Muskler_ex2();
            await Navigation.PushAsync(Exercise_Anatomi_Muskler_ex2);

        }
    }
}