using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CLC_Proj.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLC_Proj.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterFormResults(UserModel user)
        {
            if (SubmitRegistration(user) == true)
            {
                return View("RegisterFormResults", user);
            }
            else
            {
                return View("RegisterFormResults", user);
            }
        }
        [HttpPost]
        public bool SubmitRegistration(UserModel user)
        {
            bool success = false;

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string sqlStatement = string.Format("INSERT INTO dbo.RegInfo (FIRSTNAME, LASTNAME, SEX, AGE, STATE, EMAIL, USERNAME, PASSWORD) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}')", user.firstName.ToString(), user.lastName.ToString(), user.sex.ToString(), user.age, user.state.ToString(), user.email.ToString(), user.userName.ToString(), user.password.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                success = true;
            }

            return success;
        }
    }
}
