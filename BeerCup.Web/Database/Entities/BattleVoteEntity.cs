using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BattleVoteEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int BattleId { get; set; }

        public int VoterId { get; set; }

        public int BeerNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
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