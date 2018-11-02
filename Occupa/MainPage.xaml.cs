using BookClient.Data;
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
        readonly IList<Book> books = new ObservableCollection<Book>();
        readonly BookManager manager = new BookManager();

        public MainPage()
        {

            BindingContext = books;
            InitializeComponent();
        }


        async void OnRefresh(object sender, EventArgs e)
        {
            // Turn on network indicator
            this.IsBusy = true;

            try
            {
                var bookCollection = await manager.GetAll();

                foreach (Book book in bookCollection)
                {
                    if (books.All(b => b.name != book.name)) ;
                  
                }
            }
            finally
            {
                this.IsBusy = false;
            }
        }

    }
}


