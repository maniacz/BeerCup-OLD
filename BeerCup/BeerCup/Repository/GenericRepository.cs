using BeerCup.Contracts.Repository;
using BeerCup.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace BeerCup.Repository
{
    public class GenericRepository : IGenericRepository
    {
        public async Task<T> GetAsync<T>(string uri, string authToken = "")
        {
            try
            {
                //todo: Sprawdź coś tu jest nie tak z argumentem uri bo w Bethany w samej już metodzie uri zmienia się w authToken ???
                HttpClient httpClient = CreateHttpClient(uri);
                string jsonResult = string.Empty;

                //todo: Zaimplementuj Retry policy z Poli
                var responseMessage = await httpClient.GetAsync(uri);

                if (responseMessage.IsSuccessStatusCode)
                {
                    jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var json = JsonConvert.DeserializeObject<T>(jsonResult);
                    return json;
                }

                if (responseMessage.StatusCode == System.Net.HttpStatusCode.Forbidden ||
                    responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new ServiceAuthenticationException(jsonResult);
                }

                throw new HttpRequestExceptionEx(responseMessage.StatusCode, jsonResult, null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.GetType().Name + " : " + ex.Message}");
                throw;
            }
        }

        //todo: W Bethany mamy sygnaturę z authToken private HttpClient CreateHttpClient(string authToken) ???
        private HttpClient CreateHttpClient(string uri)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //todo: authorization token check

            return httpClient;
        }
    }
}
