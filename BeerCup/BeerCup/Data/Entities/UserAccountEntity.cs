using System;
using System.Collections.Generic;
using System.Text;

namespace BeerCup.Data.Entities
{
    public class UserAccountEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserAccountEntity(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
