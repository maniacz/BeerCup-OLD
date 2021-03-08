using BeerCup.Contracts.Services.General;
using BeerCup.Enums;
using BeerCup.Models;
using BeerCup.ViewModels.Base;
using System;
using System.Collections.ObjectModel;

namespace BeerCup.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ObservableCollection<MainMenuItem> _menuItems;

        public MenuViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            MenuItems = new ObservableCollection<MainMenuItem>();
            LoadMenuItems();
        }

        public ObservableCollection<MainMenuItem> MenuItems 
        { 
            get => _menuItems;
            set 
            {
                _menuItems = value;
                OnPropertyChanged();
            } 
        }

        private void LoadMenuItems()
        {
            MenuItems.Add(new MainMenuItem
            {
                MenuText = "Home",
                ViewModelToLoad = typeof(MainViewModel),
                MenuItemType = MenuItemType.Home
            });
        }
    }
}