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
	public partial class Exercise_Psykologi_Kognitiv : ContentPage
	{
		public Exercise_Psykologi_Kognitiv ()
		{
			InitializeComponent ();
		}
        private async void Clicked_btn_Psykologi_Udvikling(object sender, EventArgs e)
        {
            var Exercise_Psykologi_Udvikling = new Exercise_Psykologi_Udvikling();
            await Navigation.PushAsync(Exercise_Psykologi_Udvikling);
        }

        private async void Clicked_btn_Psykologi_Kognitiv(object sender, EventArgs e)
        {
            var Exercise_Psykologi_Kognitiv = new Exercise_Psykologi_Kognitiv();
            await Navigation.PushAsync(Exercise_Psykologi_Kognitiv);
        }

        private async void Clicked_btn_Psykologi_Kognitiv_ex1(object sender, EventArgs e)
        {
            var Exercise_Psykologi_Kognitiv_ex1 = new Exercise_Psykologi_Kognitiv_ex1();
            await Navigation.PushAsync(Exercise_Psykologi_Kognitiv_ex1);

        }
        private async void Clicked_btn_Psykologi_Kognitiv_ex2(object sender, EventArgs e)
        {
            var Exercise_Psykologi_Kognitiv_ex2 = new Exercise_Psykologi_Kognitiv_ex2();
            await Navigation.PushAsync(Exercise_Psykologi_Kognitiv_ex2);
        }
    }
}