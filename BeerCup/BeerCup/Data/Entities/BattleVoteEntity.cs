using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BattleVoteEntity
    {
        public int Id { get; set; }

        public int BattleId { get; set; }

        public int VoterId { get; set; }

        public int BeerNumber { get; set; }

        public DateTime CTime { get; set; }

        public BattleVoteEntity()
        {
        }

        public BattleVoteEntity(int battleId, int voterId, int beerNumber)
        {
            BattleId = battleId;
            VoterId = voterId;
            BeerNumber = beerNumber;
            CTime = DateTime.Now;
        }
    }
}