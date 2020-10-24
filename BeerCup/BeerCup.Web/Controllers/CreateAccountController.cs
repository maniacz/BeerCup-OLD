using BeerCup.Web.Controllers.Repositories;
using BeerCup.Web.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeerCup.Web.Controllers
{
    public class CreateAccountController : ApiController
    {
        private ICreateAccountRepository createAccountRepository;

        public CreateAccountController(ICreateAccountRepository createAccountRepository)
        {
            this.createAccountRepository = createAccountRepository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "elo";
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] CreateAccountRequestDto request)
        {
            if (request == null || !(ModelState.IsValid))
                return BadRequest(ModelState);

            try
            {
                createAccountRepository.Add(request);
                createAccountRepository.Save();
            }
            catch (Exception)
            {

                throw;
            }

            return Ok();
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