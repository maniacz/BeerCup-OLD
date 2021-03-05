using BeerCup.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Contracts.Services.General
{
    public interface INavigationService
    {
        //todo: uzupełnić
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
    }
}
