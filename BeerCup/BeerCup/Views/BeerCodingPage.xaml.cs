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
    public partial class BeerCodingPage : ContentPage
    {
        private BeerCodingViewModel _vm;

        public BeerCodingPage()
        {
            InitializeComponent();

            BindingContext = _vm = new BeerCodingViewModel();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            _vm.BreweriesCountChangedCommand.Execute(sender);
        }
    }
}