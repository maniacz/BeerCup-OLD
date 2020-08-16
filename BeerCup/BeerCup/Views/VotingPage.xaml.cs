using BeerCup.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeerCup.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VotingPage : ContentPage
    {
        private Battle battle;

        public VotingPage()
        {
            InitializeComponent();
        }

        public VotingPage(Battle battle)
        {
            InitializeComponent();

            this.battle = battle;
        }
    }
}
