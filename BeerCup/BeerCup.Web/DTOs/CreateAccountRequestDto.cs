using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerCup.Web.DTOs
{
    public class CreateAccountRequestDto
    {
        [Required]
        [MinLength(4), MaxLength(32)]
        public string Username { get; set; }

        [Required]
        [MinLength(4), MaxLength(32)]
        public string Password { get; set; }
    }
}