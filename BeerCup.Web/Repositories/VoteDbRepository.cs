using BeerCup.Web.Database;
using BeerCup.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Repositories
{
    public class VoteDbRepository : IVoteRepository
    {
        private DatabaseContext dbContext = new DatabaseContext();
        public void Add(BattleVoteEntity vote)
        {
            dbContext.BattleVotes.Add(vote);
        }

        public List<BattleVoteEntity> GetAll()
        {
            return dbContext.BattleVotes.ToList();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}