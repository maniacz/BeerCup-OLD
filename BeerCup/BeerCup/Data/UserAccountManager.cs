using BeerCup.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Data
{
    public class UserAccountManager
    {
        const string Url = "http://10.0.2.2/BeerCup.Web/api/CreateAccount";

        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();

            //todo: Ogarnij autoryzację [region kod zakomentowany]
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

        internal async Task<string> RegisterNewUser(string userName, string password)
        {
            HttpClient client = await GetClient().ConfigureAwait(false);
            UserAccountEntity newUser = new UserAccountEntity(userName, password);

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(newUser), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(Url, content);

                if (!response.IsSuccessStatusCode)
                {
                    //return await response.Content.ReadAsStringAsync();
                    //todo: wywalić tego tempa przy releasie
                    var temp = response.Content.ReadAsStringAsync().Result;
                    throw new HttpRequestException("User not created");
                }

                response.EnsureSuccessStatusCode();
                return "OK";
            }
            catch (HttpRequestException ex)
            {
                return ex.Message;
            }
        }
    }
}
