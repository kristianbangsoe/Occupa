using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace occupaTab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void clicked_anatomi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = true;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void clicked_fysiologi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = true;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void clicked_psykologi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = true;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void clicked_pædagogik(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = true;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void clicked_ergoterapi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = true;
            box_sygdomslære.IsVisible = false;

        }

        private void clicked_sygdomslære(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = true;

        }

        private async void clicked_btn_anatomi_muskler(object sender, EventArgs e)
        {
            var Exercise_Anatomi_Muskler = new Exercise_Anatomi_Muskler();
            await Navigation.PushAsync(Exercise_Anatomi_Muskler);
        }

        private async void clicked_btn_anatomi_skelettet(object sender, EventArgs e)
        {
            var Exercise_Anatomi_Skelettet = new Exercise_Anatomi_Skelettet();
            await Navigation.PushAsync(Exercise_Anatomi_Skelettet);
        }



    }
}