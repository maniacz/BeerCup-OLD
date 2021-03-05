using BeerCup.Contracts.Services.General;
using BeerCup.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private MenuViewModel _menuViewModel;

        public MainViewModel(INavigationService navigationService, MenuViewModel menuViewModel)
            : base(navigationService)
        {
            _menuViewModel = menuViewModel;
        }

        public MenuViewModel MenuViewModel {
            get => _menuViewModel;
            set 
            {
                _menuViewModel = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object data)
        {
            await Task.WhenAll
                (
                    _menuViewModel.InitializeAsync(data),
                    //todo: W Bethany jest NavigateToAsync<HomeViewModel>()
                    _navigationService.NavigateToAsync<VotingViewModel>()
                );
        }
    }
}
