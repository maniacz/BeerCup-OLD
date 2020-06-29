using BeerCup.Web.Database.Entities;
using BeerCup.Web.Controllers.Repositories;
using BeerCup.Web.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCup.Web.Database.Repositories
{
    public class CreateAccountRepository : ICreateAccountRepository
    {
        private BeerCupContext dbContext = new BeerCupContext();

        public void Add(CreateAccountRequestDto newAccount)
        {
            dbContext.Users.Add(new UserAccount
            {
                UserName = newAccount.Username,
                Password = newAccount.Password
            });
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}