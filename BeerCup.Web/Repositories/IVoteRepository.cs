using BeerCup.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Web.Repositories
{
    public interface IVoteRepository
    {
        void Add(BattleVoteEntity vote);
        List<BattleVoteEntity> GetAll();

        void Save();
    }
}
