using BeerCup.Web.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Repositories
{
    public class BreweryRepository : IBreweryRepository
    {
        private BeerCupContext _dbContext = new BeerCupContext();

        public List<Brewery> GetBreweriesStartingInBattle(int battleId)
        {
            var startingBreweries = 
                _dbContext.Breweries
                .Join(_dbContext.BreweryBattle,
                    b => b.Id,
                    bb => bb.BreweryId,
                    (b, bb) => new
                    {
                        BreweryName = b.BreweryName,
                        BattleId = bb.BattleId
                    })
                .Where(a => a.BattleId == battleId)
                .Select(a => new Brewery
                {
                    BreweryName = a.BreweryName
                })
                .ToList();

            return startingBreweries;
        }
    }
}