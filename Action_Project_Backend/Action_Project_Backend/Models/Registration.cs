using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Action_Project_Backend.Models
{
    public class Registration
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string userType { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}