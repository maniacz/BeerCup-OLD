using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class Battle
    {
        public Battle()
        {
            BreweryBattles = new List<BreweryBattle>();
        }

        public int Id { get; set; }

        public string BattleStyle { get; set; }

        public DateTime BattleStartTime { get; set; }

        public DateTime BattleEndTime { get; set; }

        public List<BreweryBattle> BreweryBattles { get; set; }
    }

}