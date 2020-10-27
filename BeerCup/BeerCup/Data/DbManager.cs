using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace BeerCup
{
    public class DbManager
    {
        private string authorizationKey;

        protected async Task<HttpClient> GetClient()
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
    }
}
