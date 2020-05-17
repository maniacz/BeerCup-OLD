using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerCup.Web.EFCore.Database.Entities
{
    public class Battle
    {
        public Battle()
        {
            BreweryBattles = new List<BreweryBattle>();
        }

        public int Id { get; set; }

        public string BattleStyle { get; set; }

        public DateTime BattleStartTime { get; set; }

        public DateTime BattleEndTime { get; set; }

        public List<BreweryBattle> BreweryBattles { get; set; }
    }
}