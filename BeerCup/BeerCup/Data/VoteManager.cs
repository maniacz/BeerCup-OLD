using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BeerCup.Web.Database.Entities;

namespace BeerCup.Data
{
    public class VoteManager
    {
        const string Url = "https://localhost:44328/api/vote/";

        private string authorizationKey;

        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();

            //todo: Ogarnij autoryzację
            #region Authorization
            if (string.IsNullOrEmpty(authorizationKey))
            {
                authorizationKey = await client.GetStringAsync(Url + "login");
                authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);
            }

            client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
            #endregion

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        internal async Task<IEnumerable<BattleVoteEntity>> GetAllVotes()
        {
            return null;
        }

        internal async Task SendYourVotes(List<byte> selectedBeers)
        {

        }
    }
}
