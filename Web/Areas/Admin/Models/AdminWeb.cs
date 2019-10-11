using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Areas.Admin.Models
{
    public class AdminWeb
    {
        private string username;
        private string password;

        [Required(ErrorMessage = "Request username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Request password")]
        public string Password { get; set; }
    }
}