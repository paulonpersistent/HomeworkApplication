using Action_Project_Backend.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Action_Project_Backend.Controllers
{
    public class UserController : ApiController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        [HttpPost]
        [Route("registration")]
        public string registration(Registration reg)
        {
            SqlCommand cmd = new SqlCommand("Insert into UserAccount(Name,userType,Password,Email,PhoneNumber) values(' " + reg.Name + " ' , ' " + reg.userType + " ',' " + reg.Password + " ',' " + reg.Email + " ',' " + reg.PhoneNumber + " ' )", conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                return "Data inserted";
            }

            else
            {
                return "";
            }
        }

        [HttpPost]
        [Route("login")]
        public string login(Login reg)
        {
            SqlDataAdapter sd = new SqlDataAdapter("(select * from UserAccount where Email = ' " + reg.Email + " ' and Password = + ' " + reg.Password + " ' and userType = + ' " + reg.userType + " ' )", conn);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return "Data Found";
            }

            else
            {
                return "User Not Found";
            }
        }
    }
}
