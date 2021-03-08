using BeerCup.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BeerCup.Models
{
    public class MainMenuItem : BindableObject
    {
        private string _menuText;
        private MenuItemType _menuItemType;
        private Type _viewModelToLoad;

        public string MenuText 
        {
            get => _menuText;
            set 
            {
                _menuText = value;
                OnPropertyChanged();
            } 
        }

        public MenuItemType MenuItemType 
        {
            get => _menuItemType;
            set
            {
                _menuItemType = value;
                OnPropertyChanged();
            } 
        }

        public Type ViewModelToLoad
        {
            get => _viewModelToLoad;
            set
            {
                _viewModelToLoad = value;
                OnPropertyChanged();
            }
        }
    }
}
