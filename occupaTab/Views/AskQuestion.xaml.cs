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
	public partial class AskQuestion : ContentPage
	{
		public AskQuestion ()
		{
			InitializeComponent ();
		}

        public async void HandleCancel(object sender, EventArgs e)
        {
            var MainPage = new AskQuestion();
            await Navigation.PushModalAsync(MainPage);
        }

        public async void HandleSendQuestion(object sender, EventArgs e)
        {
            var MainPage = new AskQuestion();
            await Navigation.PushModalAsync(MainPage);
        }
	}
}