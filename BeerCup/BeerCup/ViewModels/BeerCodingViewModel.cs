using BeerCup.Data;
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
        public ObservableCollection<StartingBrewery> StartingBreweriesList { get; set; }

        private List<string> pickerItems;
        private string firstPickerItem;

        public ICommand ConfirmBeerCodingCommand { get; }
        public ICommand BreweriesCountChangedCommand { get; }

        public BeerCodingViewModel()
        {
            pickerItems = PopulateCollection();
            firstPickerItem = pickerItems.FirstOrDefault();
            PopulateDiscoveredItemList();

            ConfirmBeerCodingCommand = new Command(OnConfirmBeerCodingCommand);
            BreweriesCountChangedCommand = new Command(OnBreweriesCountChangedCommand);
        }


        private void OnBreweriesCountChangedCommand(object stepper)
        {
            double stepperValue = (stepper as Stepper).Value;

            if (stepperValue > StartingBreweriesList.Count)
            {
                StartingBreweriesList.Add(new StartingBrewery { PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id = (int)stepperValue });
            }

            if (stepperValue < StartingBreweriesList.Count)
            {
                StartingBreweriesList.Remove(StartingBreweriesList.Last());
            }
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
            StartingBreweriesList = new ObservableCollection<StartingBrewery>()
            {
                new StartingBrewery {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=1},
                new StartingBrewery {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=2},
                new StartingBrewery {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=3},
                new StartingBrewery {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=4},
                new StartingBrewery {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=5},
            };

            foreach (var discoveredItem in StartingBreweriesList)
            {
                discoveredItem.PickedEvent += BreweryPicked;
            }
        }

        private void BreweryPicked()
        {

        }

        

        private void OnConfirmBeerCodingCommand()
        {
            if (IsBeerCodingOk())
            {
                Dictionary<int, string> beerCoding = GetBeerCoding();
                BeerCodingManager beerCodingManager = new BeerCodingManager();
                beerCodingManager.ConfirmBeerCodingForBattle(beerCoding);
            }
        }

        private Dictionary<int, string> GetBeerCoding()
        {
            Dictionary<int, string> beerCoding = new Dictionary<int, string>();
            foreach (var item in StartingBreweriesList)
            {
                beerCoding.Add(item.id, item.SelectedPickerItem);
            }

            return beerCoding;
        }

        private bool IsBeerCodingOk()
        {
            List<string> selectedBreweries = new List<string>();
            //StartingBreweriesList.ForEach((x) => selectedBreweries.Add(x.SelectedPickerItem));

            int distinctBreweriesSelected = selectedBreweries.Distinct().Count();
            if (distinctBreweriesSelected < StartingBreweriesList.Count)
            {
                //todo: Niezgodne z MVVM
                App.Current.MainPage.DisplayAlert("Kodowanie piw", "Niepoprawne kodowanie piw \nPowtórzony browar", "OK");
                return false;
            }
            else
            {
                return true;
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

    internal class StartingBrewery : BaseViewModel
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
