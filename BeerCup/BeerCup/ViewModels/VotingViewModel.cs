using BeerCup.Data;
using BeerCup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.MultiSelectListView;

namespace BeerCup.ViewModels
{
    class VotingViewModel : INotifyPropertyChanged
    {
        #region Property

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

        #endregion

        public MultiSelectObservableCollection<Beer> Beers { get; }

        public ICommand VoteCommand => new Command(Vote);
        //public ICommand VoteCommand { get { return new Command(Vote); } }

        public VotingViewModel()
        {
            Beers = new MultiSelectObservableCollection<Beer>();

            for (byte i = 1; i < 6; i++)
            {
                Beer beer = new Beer { BeerNumber = i };
                Beers.Add(beer);
            }

            //Beers[0].IsSelected = true;
            //Beers[1].IsSelected = true;
        }

        VoteManager voteManager = new VoteManager();
        List<byte> selectedBeers = new List<byte>();
        async void Vote()
        {
            if (NumberOfBeersSelected() != 2)
            {
                await Application.Current.MainPage.DisplayAlert("Głosowanie", "Musisz wybrać 2 piwa", "OK");
                //Device.BeginInvokeOnMainThread(async () => { await Application.Current.MainPage.DisplayAlert("Głosowanie", "Musisz wybrać 2 piwa", "OK"); });
                return;
            }

            //bool selectionConfirmed = await Application.Current.MainPage.DisplayAlert("Głosowanie", "Czy chcesz zagłosować na piwa nr " + SelectedBeers(), "Tak", "Nie");
            //if (selectionConfirmed)
            //{
            //    await voteManager.SendYourVotes(selectedBeers);
            //}

            SelectedBeers();
            await voteManager.SendYourVotes(selectedBeers);
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

        private string SelectedBeers()
        {
            foreach (var beer in Beers)
            {
                if (beer.IsSelected)
                    selectedBeers.Add(beer.Data.BeerNumber);
            }
            return string.Join(" oraz ", selectedBeers);
        }

        public ICommand SelectBeer => new Command<Beer>(beer =>
        {
            {
                //Switch value of IsChosenByVoter
                if (beer.IsChosenByVoter)
                    beer.IsChosenByVoter = false;
                else
                    beer.IsChosenByVoter = true;
            }
        });
    }
}
