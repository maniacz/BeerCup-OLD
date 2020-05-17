using BeerCup.Web.EFCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Models
{
    public class VotesResponse : BaseResponse
    {
        public List<BattleVote> Votes { get; set; }
        public List<Battle> Battles { get; set; }
    }
}