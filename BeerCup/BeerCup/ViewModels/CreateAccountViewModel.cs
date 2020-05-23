using BeerCup.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BeerCup.ViewModels
{
    public class CreateAccountViewModel : BaseViewModel
    {
        UserAccountManager userAccountManager;

        public CreateAccountViewModel()
        {
            userAccountManager = new UserAccountManager();
        }

        async internal void RegisterUser(string userName, string password)
        {
            await userAccountManager.RegisterNewUser(userName, password);
        }
    }
}
