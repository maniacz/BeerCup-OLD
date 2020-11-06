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

        public List<string> GetCurrentBattleBreweries()
        {
            List<string> currentBattleBreweries = dbContext.Breweries.Where(b => dbContext.BattleBreweries
                .Where(bb => bb.BattleId == dbContext.CurrentBattle.Select(cb => cb.BattleId).FirstOrDefault())
                .Select(bb => bb.BreweryId)
                .Contains(b.Id))
                .Select(b => b.BreweryName)
                .ToList();

            return currentBattleBreweries;
        }
    }
}