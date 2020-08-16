using BeerCup.Web.Database.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using BeerCup.Web.Database.Entities;

namespace BeerCup.Data
{
    public class VoteManager
    {
        //const string Url = "http://localhost/BeerCup.Web/api/vote";
        const string Url = "http://10.0.2.2/BeerCup.Web/api/vote";

        private string authorizationKey;

        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();

            //todo: Ogarnij autoryzację
            #region Authorization
            /*
            if (string.IsNullOrEmpty(authorizationKey))
            {
                authorizationKey = await client.GetStringAsync(Url + "login");
                authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);
            }

            client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
            */
            #endregion

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        /*
        internal async Task<IEnumerable<BattleVoteEntity>> GetAllVotes()
        {
            return null;
        }
        */

        internal async Task SendYourVotes(List<byte> selectedBeers)
        {
            foreach (byte beerNo in selectedBeers)
            {
                try
                {
                    await VoteForTheBeer(beerNo);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


        }

        private bool isBusy = false;
        private async Task VoteForTheBeer(byte beerNo)
        {
            HttpClient client = await GetClient().ConfigureAwait(false);
            //todo: Trzeba zaimplementować przypisywanie wartości battleId i voterId
            BattleVoteEntity vote = new BattleVoteEntity(3, 3, beerNo);
            StringContent content = new StringContent(JsonConvert.SerializeObject(vote), Encoding.UTF8, "application/json");
            string tempJsonContent = await content.ReadAsStringAsync();

            if (!isBusy)
            {
                isBusy = true;
                var response = await client.PostAsync(Url, content);
                response.EnsureSuccessStatusCode();
                isBusy = false;
            }
        }

        public async void GetAllVotes()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(Url);
            response.EnsureSuccessStatusCode();
        }
    }
}
