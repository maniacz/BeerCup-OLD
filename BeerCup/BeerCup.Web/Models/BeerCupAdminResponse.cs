using BeerCup.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Models
{
    public class BeerCupAdminResponse : BaseResponse
    {
        public List<string> CurrentBattleBreweries { get; set; }
    }
}