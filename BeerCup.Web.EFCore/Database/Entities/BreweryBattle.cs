using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerCup.Web.EFCore.Database.Entities
{
    public class BreweryBattle
    {
        public int BreweryId { get; set; }

        public int BattleId { get; set; }

        public int FinalRank { get; set; }

        public int VotesReceived { get; set; }
    }
}