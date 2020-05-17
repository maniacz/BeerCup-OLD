using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerCup.Web.EFCore.Database.Entities
{
    public class Brewery
    {
        public Brewery()
        {
            BreweryBattles = new List<BreweryBattle>();
        }

        public int Id { get; set; }

        public string BreweryName { get; set; }

        public string BreweryOwner { get; set; }

        public List<BreweryBattle> BreweryBattles { get; set; }
    }
}