using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BattleVote
    {
        public int Id { get; set; }

        public int BattleId { get; set; }

        public int VoterId { get; set; }

        public int BeerNumber { get; set; }

        public DateTime CTime { get; set; }
    }
}