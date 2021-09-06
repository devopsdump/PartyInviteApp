using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInviteApp.Models
{
    public class PartyInvitation
    {
      
        [Required(ErrorMessage = "Please, provide your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, provide your email address")]
        [EmailAddress]
        public string Email { get; set; }

        public bool? WillCome { get; set; }
        
    }
}
