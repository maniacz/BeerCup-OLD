using BeerCup.Web.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database
{
    public class BeerCupContext : DbContext
    {
        public BeerCupContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information)
            //.AddConsole();
            .AddDebug();
        });

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

            //poniższy connection string działa dla normalnego (not elevated) usera
            //optionsBuilder.UseSqlServer(@"Data Source = .\SQLEXPRESS; Initial Catalog = BeerCupData; Trusted_Connection=True;");

            //connection string dla usera bazodanowego - sa
            optionsBuilder
                .UseLoggerFactory(loggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlServer(@"Data Source = .\SQLEXPRESS; Initial Catalog = BeerCupData; User ID = sa; Password=sysadmin1.;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BreweryBattle>()
                .HasKey(bb => new { bb.BreweryId, bb.BattleId });
            modelBuilder.Entity<BreweryBattle>()
                .HasOne(brbt => brbt.Brewery)
                .WithMany(br => br.BreweryBattles)
                .HasForeignKey(brbt => brbt.BreweryId);
            modelBuilder.Entity<BreweryBattle>()
                .HasOne(brbt => brbt.Battle)
                .WithMany(bt => bt.BreweryBattles)
                .HasForeignKey(brbt => brbt.BattleId);

            modelBuilder.Entity<BattleVote>().Property(v => v.CTime).HasDefaultValueSql("getdate()");
        }

        //todo: Tego konstruktora nalezy użyć w docelowej aplikacji ze względu na disconnected scenario
        /*
        public BeerCupContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        */

        public DbSet<Battle> Battles { get; set; }

        public DbSet<BreweryBattle> BreweryBattle { get; set; }

        public DbSet<BattleVote> BattlesVotes { get; set; }

        public DbSet<Brewery> Breweries { get; set; }

        public DbSet<UserAccount> Users { get; set; }
    }
}