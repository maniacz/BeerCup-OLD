using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Entities
{
    public class BattleEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string BattleStyle { get; set; }

        public DateTime BattleStartTime { get; set; }

        public DateTime BattleEndTime { get; set; }
    }
}