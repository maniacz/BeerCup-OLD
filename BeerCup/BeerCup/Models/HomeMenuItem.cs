using System;
using System.Collections.Generic;
using System.Text;

namespace BeerCup.Models
{
    public enum MenuItemType
    {
        TodaysBattle,
        MyAccount,
        Battles,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
