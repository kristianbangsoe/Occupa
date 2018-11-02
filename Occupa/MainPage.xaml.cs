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
        readonly IList<GroupsModel> groups = new ObservableCollection<GroupsModel>();
        readonly GroupsManagerModel manager = new GroupsManagerModel();

        public MainPage()
        {

            BindingContext = groups;
            InitializeComponent();
        }


        async void OnRefresh(object sender, EventArgs e)
        {
            // Turn on network indicator
            this.IsBusy = true;

            try
            {
                var groupCollection = await manager.GetAll();

                foreach (GroupsModel group in groupCollection)
                {
                    if (groups.All(b => b.Name != group.Name))
                    {
                        groups.Add(group);
                    }
                  
                }
            }
            finally
            {
                this.IsBusy = false;
            }
        }

    }
}


