using BeerCup.Web.EFCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Web.Repositories
{
    public interface IVoteRepository
    {
        void Add(BattleVote vote);
        List<BattleVote> GetAll();

        List<Battle> GetBattles();

        void Save();
    }
}
