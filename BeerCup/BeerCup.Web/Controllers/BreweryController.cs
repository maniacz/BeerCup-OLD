using BeerCup.Web.Database.Repositories;
using BeerCup.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeerCup.Web.Controllers
{
    public class BreweryController : ApiController
    {
        private IBreweryRepository breweryRepository;

        public BreweryController(IBreweryRepository breweryRepository)
        {
            this.breweryRepository = breweryRepository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        //public HttpResponseMessage GetBreweriesByBattleId(int id)
        public HttpResponseMessage Get(int id)
        {
            BreweriesResponse response = new BreweriesResponse();

            try
            {
                response.StartingBreweries = breweryRepository.GetBreweriesStartingInBattle(id);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}