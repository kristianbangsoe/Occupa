﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace occupaTab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise_Anatomi_Muskler_ex1 : ContentPage
	{
		public Exercise_Anatomi_Muskler_ex1 ()
		{
			InitializeComponent ();
		}

        private async void Clicked_btn_Anatomi_Muskler_Ask_Question(object sender, EventArgs e)
        {

            var AskQuestion = new AskQuestion();
            await Navigation.PushModalAsync(AskQuestion);

        }
    }
}