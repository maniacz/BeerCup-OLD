using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BattleResultsEntity
    {
        public int BattleId { get; set; }

        public int FinalRank { get; set; }

        public int BreweryId { get; set; }

        public int VotesReceived { get; set; }
    }
}