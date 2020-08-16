using System;
using System.Collections.Generic;
using System.Text;

namespace BeerCup.Models
{
    public class Brewery
    {
        public string BreweryName { get; set; }

        public Brewery(string name)
        {
            BreweryName = name;
        }
    }
}
