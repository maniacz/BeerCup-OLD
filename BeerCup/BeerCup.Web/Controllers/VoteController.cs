using BeerCup.Web.Database.Entities;
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
    public class VoteController : ApiController
    {
        private IVoteRepository voteRepository;

        public VoteController(IVoteRepository voteRepository)
        {
            this.voteRepository = voteRepository;
        }

        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var response = new VotesResponse();

            try
            {
                response.Votes = voteRepository.GetAll();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post(BattleVote vote)
        {
            var response = new BaseResponse();

            try
            {
                voteRepository.Add(vote);
                voteRepository.Save();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }


        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}