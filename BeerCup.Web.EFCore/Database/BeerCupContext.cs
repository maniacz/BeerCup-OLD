using BeerCup.Web.EFCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.EFCore.Database
{
    public class BeerCupContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BeerCupData");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BreweryBattle>().HasKey(b => new { b.BreweryId, b.BattleId });
            modelBuilder.Entity<BattleVote>().Property(v => v.CTime).HasDefaultValueSql("getdate()");
        }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<BreweryBattle> BattlesResults { get; set; }

        public DbSet<BattleVote> BattlesVotes { get; set; }

        public DbSet<Brewery> Breweries { get; set; }
    }
}