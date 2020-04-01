using BeerCup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.MultiSelectListView;

namespace BeerCup.ViewModels
{
    class VotingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public MultiSelectObservableCollection<Beer> Beers { get; }

        public ICommand VoteCommand => new Command(Vote);

        public VotingViewModel()
        {
            Beers = new MultiSelectObservableCollection<Beer>();

            for (byte i = 1; i < 6; i++)
            {
                Beer beer = new Beer { BeerNumber = i };
                Beers.Add(beer);
            }

            //Beers[0].IsSelected = true;
        }

        async void Vote()
        {
            if (NumberOfBeersSelected() != 2)
                await Application.Current.MainPage.DisplayAlert("Głosowanie", "Musisz wybrać 2 piwa", "OK");
                //Device.BeginInvokeOnMainThread(async () => { await Application.Current.MainPage.DisplayAlert("Głosowanie", "Musisz wybrać 2 piwa", "OK"); });
        }

        private int NumberOfBeersSelected()
        {
            int selectedBeersCount = 0;
            foreach (var beer in Beers)
            {
                if (beer.IsSelected)
                    selectedBeersCount++;
            }
            return selectedBeersCount;
        }
    }
}
