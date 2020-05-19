using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BreweryBattle
    {
        public int BreweryId { get; set; }

        public int BattleId { get; set; }

        public int FinalRank { get; set; }

        public int VotesReceived { get; set; }
    }
}