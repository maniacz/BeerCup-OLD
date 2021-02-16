using BeerCup.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Models
{
    public class BreweriesResponse : BaseResponse
    {
        public List<Brewery> StartingBreweries { get; set; }
    }
}