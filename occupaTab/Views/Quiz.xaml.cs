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
	public partial class Quiz : ContentPage
	{
        Color forkert = Color.FromRgba(255, 0, 0, 0.5);
        Color rigtigt = Color.FromRgba(0, 255, 0, 0.5);

        public Quiz ()
		{
			InitializeComponent ();
		}
        

        private void Quiz1_A(object sender, EventArgs e)
        {
         
            Button btn = (Button)sender;
            btn.BackgroundColor = forkert;
            btn.BorderWidth = 1;
            btn.BorderColor = forkert;
          
        }

        private void Quiz1_B(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btn.BackgroundColor = rigtigt;
            btn.BorderWidth = 1;
            btn.BorderColor = rigtigt;
        }

        private void Quiz1_C(object sender, EventArgs e)
        {

        }

        private void Quiz1_D(object sender, EventArgs e)
        {

        }

        private void Quiz2_A(object sender, EventArgs e)
        {

        }

        private void Quiz2_B(object sender, EventArgs e)
        {

        }

        private void Quiz2_C(object sender, EventArgs e)
        {

        }

        private void Quiz2_D(object sender, EventArgs e)
        {

        }

        private void Quiz3_A(object sender, EventArgs e)
        {

        }

        private void Quiz3_B(object sender, EventArgs e)
        {

        }

        private void Quiz3_C(object sender, EventArgs e)
        {

        }

        private void Quiz3_D(object sender, EventArgs e)
        {

        }
    }
}