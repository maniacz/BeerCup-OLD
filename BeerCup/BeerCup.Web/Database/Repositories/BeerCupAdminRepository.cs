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
            //int currentBattleId = 1;
            //var currentBattleBreweries = dbContext.Breweries
            //    .Where(br => br.Id == dbContext.Battles
            //    .Where(bt => bt.Id == currentBattleId).Select(bt => bt.Id).FirstOrDefault()).ToList();

            var currentBattleBreweries = dbContext.Breweries
                .Where(br => br.Id == dbContext.Battles
                .Where(bt => bt.Id == dbContext.CurrentBattle
                .Select(cb => cb.BattleId).FirstOrDefault()).Select(bt => bt.Id).FirstOrDefault()).ToList();

            return currentBattleBreweries;
        }
    }
}