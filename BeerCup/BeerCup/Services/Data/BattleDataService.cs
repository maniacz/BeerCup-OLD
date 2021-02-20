using BeerCup.Constants;
using BeerCup.Contracts.Repository;
using BeerCup.Contracts.Services.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Services.Data
{
    public class BattleDataService : BaseService, IBattleDataService
    {
        private readonly IGenericRepository _genericRepository;

        //todo: Dorobić cachowanie za pomocą Akavache
        public BattleDataService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<string>> GetStartingInBattleBreweryNamesAsync()
        {
            //todo: Dorobić cachowanie za pomocą Akavache

            UriBuilder uriBuilder = new UriBuilder(ApiConstants.BaseApiUrl)
            {
                Path = ApiConstants.BattleEndpoint
            };

            var startingBreweries = await _genericRepository.GetAsync<List<string>>(uriBuilder.ToString());

            return startingBreweries;
        }
    }
}
