using BeerCup.Contracts.Services.General;
using BeerCup.Data;
using BeerCup.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BeerCup.ViewModels
{
    public class CreateAccountViewModel : ViewModelBase
    {
        UserAccountManager userAccountManager;

        public CreateAccountViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            userAccountManager = new UserAccountManager();
        }

        async internal void RegisterUser(string userName, string password)
        {
            await userAccountManager.RegisterNewUser(userName, password);
        }
    }
}
