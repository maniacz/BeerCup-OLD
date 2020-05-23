using BeerCup.Web.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database
{
    public class BeerCupContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BeerCupData; Trusted_Connection=True;");

            //optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BeerCupData;User Id=beercupadmin;Password=beercup");
            //optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BeerCupData;User Id=beercupadmin;Password=beercup;Integrated Security = False");
            //optionsBuilder.UseSqlServer(@"data source =.\SQLEXPRESS; Integrated Security = SSPI; AttachDBFilename =| DataDirectory | aspnetdb.mdf; User Instance = true");
            //optionsBuilder.UseSqlServer("LocalSqlServer");
            //optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Initial Catalog=BeerCupData;User Id=beercupadmin;Password=beercup");
            //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BeerCupData; Integrated Security = True");
            //optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Initial Catalog = BeerCupData; Integrated Security = True");
            //optionsBuilder.UseSqlServer(@"Data Source = (localdb)\v12; Initial Catalog = BeerCupData; User ID = beercupadmin; Password=beercup");
            
            //optionsBuilder.UseSqlServer(@"Data Source = np:\\.\pipe\LOCALDB#A9DE3E14\tsql\query; Initial Catalog = BeerCupData; User ID = beercupadmin; Password=beercup;");
            //optionsBuilder.UseSqlServer(@"Data Source = np:\\.\pipe\localdb#7fd6386a\tsql\query; Initial Catalog = BeerCupData; User ID = beercupadmin; Password=beercup;");

            optionsBuilder.UseSqlServer(@"Data Source = .\SQLEXPRESS; Initial Catalog = BeerCupData; Trusted_Connection=True;");
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

        public DbSet<UserAccount> Users { get; set; }
    }
}