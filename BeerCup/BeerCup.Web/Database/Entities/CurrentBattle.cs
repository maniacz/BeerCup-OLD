using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class CurrentBattle
    {
        public char Lock { get; set; }
        public int BattleId { get; set; }
    }
}