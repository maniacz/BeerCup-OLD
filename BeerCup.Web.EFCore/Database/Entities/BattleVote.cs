using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace BeerCup.Web.EFCore.Database.Entities
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