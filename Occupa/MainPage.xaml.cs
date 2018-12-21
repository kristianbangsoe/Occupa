using Occupa.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Occupa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
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

        private async void clicked_btn_anatomi(object sender, EventArgs e)
        {
            var UserLogin = new UserLogin();
            await Navigation.PushModalAsync(UserLogin);
        }
    }
}


