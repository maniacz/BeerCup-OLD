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
            BattleBreweries = new List<BattleBrewery>();
            BattleResults = new List<BattleResult>();
        }

        public int Id { get; set; }

        public string BattleStyle { get; set; }

        public DateTime BattleStartTime { get; set; }

        public DateTime BattleEndTime { get; set; }

        public List<BattleBrewery> BattleBreweries { get; set; }

        public List<BattleResult> BattleResults { get; set; }
    }

}