using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Website.ServiceReference1;

namespace Website.ViewModels
{
    public class SUser
    {

        private WebsiteDomain.User u;

        public SUser(ServiceReference1.SUser u)
        {
            Id = u.Id;
            Naam = u.Naam;
            Email = u.Email;
            Tele = u.Tele;
        }


        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Tele { get; set; }

    }

}
