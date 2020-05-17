using BeerCup.Web.EFCore.Database;
using BeerCup.Web.EFCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Repositories
{
    public class VoteDbRepository : IVoteRepository
    {
        private BeerCupContext dbContext = new BeerCupContext();
        public void Add(BattleVote vote)
        {
            dbContext.BattlesVotes.Add(vote);
        }

        public List<BattleVote> GetAll()
        {
            return dbContext.BattlesVotes.ToList();
        }

        public List<Battle> GetBattles()
        {
            return dbContext.Battles.ToList();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}