using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Action_Project_Backend.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string userType { get; set; }
    }
}