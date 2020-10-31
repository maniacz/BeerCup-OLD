using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class Brewery
    {
        public Brewery()
        {
            BreweryBattles = new List<BattleResult>();
        }

        public int Id { get; set; }

        public string BreweryName { get; set; }

        public string BreweryOwner { get; set; }

        public List<BattleResult> BreweryBattles { get; set; }
    }
}