using BeerCup.Contracts.Services.General;
using BeerCup.ViewModels.Base;

namespace BeerCup.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public MenuViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}