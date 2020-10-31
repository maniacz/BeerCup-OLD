using BeerCup.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Repositories
{
    public class BeerCupAdminRepository : IBeerCupAdminRepository
    {
        private BeerCupContext dbContext = new BeerCupContext();

        public List<Brewery> GetCurrentBattleBreweries()
        {
            throw new NotImplementedException();
        }
    }
}