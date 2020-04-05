using BeerCup.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<BattleVoteEntity> BattleVotes { get; set; }

        public DatabaseContext() : base()
        {

        }
    }
}