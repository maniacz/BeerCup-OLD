using BeerCup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
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

        public VotingViewModel()
        {
            Beers = new MultiSelectObservableCollection<Beer>();

            for (byte i = 1; i < 6; i++)
            {
                Beer beer = new Beer { BeerNumber = i };
                Beers.Add(beer);
            }

            Beers[0].IsSelected = true;
        }
    }
}
