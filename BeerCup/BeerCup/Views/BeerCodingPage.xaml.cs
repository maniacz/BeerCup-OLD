﻿using BeerCup.ViewModels;
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
        public BeerCodingPage()
        {
            InitializeComponent();

            BindingContext = new BeerCodingViewModel();
        }

        private void BreweriesCount_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
        }
    }
}