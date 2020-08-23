using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeerCup.ViewModels
{
    class BeerCodingViewModel : BaseViewModel
    {
        public List<DiscoveredItem> DiscoveredItemList { get; set; }

        private List<string> pickerItems;
        private string firstPickerItem;

        public ICommand ConfirmBeerCodingCommand { get; }

        public BeerCodingViewModel()
        {
            pickerItems = PopulateCollection();
            firstPickerItem = pickerItems.FirstOrDefault();
            PopulateDiscoveredItemList();

            ConfirmBeerCodingCommand = new Command(OnConfirmBeerCodingCommand);
        }

        private List<string> PopulateCollection()
        {
            var myCollection = new List<string>
            {
                "BroGar",
                "Hołda",
                "Kozakow",
                "Venom",
                "Citra"
            };

            return myCollection;
        }
        private void PopulateDiscoveredItemList()
        {
            DiscoveredItemList = new List<DiscoveredItem>()
            {
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=1},
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=2},
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=3},
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=4},
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=5},
            };

            foreach (var discoveredItem in DiscoveredItemList)
            {
                discoveredItem.PickedEvent += BreweryPicked;
            }
        }

        private void BreweryPicked()
        {

        }

        

        private void OnConfirmBeerCodingCommand()
        {
            ValidateBeerCoding();
        }

        private void ValidateBeerCoding()
        {
            List<string> selectedBreweries = new List<string>();
            DiscoveredItemList.ForEach((x) => selectedBreweries.Add(x.SelectedPickerItem));

            int distinctBreweriesSelected = selectedBreweries.Distinct().Count();
            if (distinctBreweriesSelected < DiscoveredItemList.Count)
            {

            }
        }

        /*
        public ObservableCollection<string> Competetors { get; set; }
        public Dictionary<int, string> BeerCoding { get; set; }

        public BeerCodingViewModel()
        {
            Competetors = new ObservableCollection<string>();
            BeerCoding = new Dictionary<int, string>();

            FillCompetetorsList();
        }

        private void FillCompetetorsList()
        {
            for (int i = 0; i < 5; i++)
            {
                Competetors.Add("Browar domowy nr " + i);
            }
        }
        */
    }

    internal class DiscoveredItem : BaseViewModel
    {
        public delegate void Picked();
        public event Picked PickedEvent;

        public int id { get; set; }

        public List<string> PickerList { get; set; }

        private string selectedPickerItem;
        public string SelectedPickerItem
        {
            get => selectedPickerItem;
            set
            {
                int x = id;
                SetValue(ref selectedPickerItem, value);
                if (PickedEvent != null)
                {
                    PickedEvent();
                }
            }
        }
    }
}
