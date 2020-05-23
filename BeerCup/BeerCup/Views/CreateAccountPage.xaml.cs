using BeerCup.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeerCup.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        CreateAccountViewModel createAccountViewModel;

        public CreateAccountPage()
        {
            InitializeComponent();
            createAccountViewModel = new CreateAccountViewModel();
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            if (Password1.Text.Equals(Password2.Text))
                createAccountViewModel.RegisterUser(UserName.Text, Password2.Text);
            else
                DisplayAlert("Rejestracja", "Podane hasła nie są takie same", "OK");
        }
    }
}