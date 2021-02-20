using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Contracts.Services.Data
{
    public interface IBattleDataService
    {
        Task<IEnumerable<string>> GetStartingInBattleBreweryNamesAsync();
    }
}
