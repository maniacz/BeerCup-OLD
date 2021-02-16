using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BreweryBattle
    {
        public int BreweryId { get; set; }
        public Brewery Brewery { get; set; }

        public int BattleId { get; set; }
        public Battle Battle { get; set; }
    }
}