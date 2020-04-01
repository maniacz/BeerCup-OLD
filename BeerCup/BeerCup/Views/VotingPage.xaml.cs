using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeerCup.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VotingPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public VotingPage()
        {
            InitializeComponent();

            //Items = new ObservableCollection<string>
            //{
            //    "Beer 1",
            //    "I 2",
            //    "Item 3",
            //    "Item 4",
            //    "Item 5"
            //};

            //MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            //((ListView)sender).SelectedItem = null;
        }

        private void VoteButton_Clicked(object sender, EventArgs e)
        {
            if (SelectedBeerCount() == 2)
            {

            }
            
        }

        private int SelectedBeerCount()
        {

            return 0;
        }
    }
}
