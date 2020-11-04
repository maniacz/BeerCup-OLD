using BeerCup.Web.Database.Entities;
using BeerCup.Web.Database.Repositories;
using BeerCup.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace BeerCup.Web.Controllers
{
    public class BeerCupAdminController : ApiController
    {
        private IBeerCupAdminRepository beerCupAdminRepository;

        public BeerCupAdminController(IBeerCupAdminRepository beerCupAdminRepository)
        {
            this.beerCupAdminRepository = beerCupAdminRepository;
        }

        [Route("api/currentbattlebreweries")]
        [HttpGet]
        public HttpResponseMessage GetCurrentBattleBreweries()
        {
            var response = new BeerCupAdminResponse();

            try
            {
                response.CurrentBattleBreweries = beerCupAdminRepository.GetCurrentBattleBreweries();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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