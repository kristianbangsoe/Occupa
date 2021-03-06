﻿using System;

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


        private void Clicked_anatomi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = true;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void Clicked_fysiologi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = true;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void Clicked_psykologi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = true;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void Clicked_pædagogik(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = true;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = false;

        }

        private void Clicked_ergoterapi(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = true;
            box_sygdomslære.IsVisible = false;

        }

        private void Clicked_sygdomslære(object sender, EventArgs e)
        {
            box_anatomi.IsVisible = false;
            box_fysiologi.IsVisible = false;
            box_psykologi.IsVisible = false;
            box_pædagogik.IsVisible = false;
            box_ergoterapi.IsVisible = false;
            box_sygdomslære.IsVisible = true;

        }

        private async void Clicked_btn_anatomi_muskler(object sender, EventArgs e)
        {
            var MainPage = new Exercise_Anatomi_Muskler();
            await Navigation.PushAsync(MainPage);
        }

        private async void Clicked_btn_anatomi_skelettet(object sender, EventArgs e)
        {
            var MainPage = new Exercise_Anatomi_Skelettet();
            await Navigation.PushAsync(MainPage);
        }

        private async void Clicked_btn_fysiologi_åndedræt(object sender, EventArgs e)
        {
            var MainPage = new Exercise_Fysiologi_Aandedraet();
            await Navigation.PushAsync(MainPage);
        }

        private async void Clicked_btn_fysiologi_forplantning(object sender, EventArgs e)
        {
            var MainPage = new Exercise_Fysiologi_Forplantning();
            await Navigation.PushAsync(MainPage);
        }

        private async void Clicked_btn_psykologi_udvikling(object sender, EventArgs e)
        {
            var MainPage = new Exercise_Psykologi_Udvikling();
            await Navigation.PushAsync(MainPage);
        }

        private async void Clicked_btn_psykologi_kognitiv(object sender, EventArgs e)
        {
            var MainPage = new Exercise_Psykologi_Kognitiv();
            await Navigation.PushAsync(MainPage);
        }

        private async void Fav_clicked(object sender, EventArgs e)
        {
            var MainPage = new FavoritePage();
            await Navigation.PushAsync(MainPage);
        }




    }
}