using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public string Login(Users userModel)
        {
            if (string.IsNullOrEmpty(userModel.EmailId) || string.IsNullOrEmpty(userModel.Password))
            {
                return "UserId and password cannot be null";
            }
            else
            {

                List<Users> list = new List<Users>();
                list.Add(new Users() { UserId = 1, FirstName = "Bhoomika", LastName = "Sadashiva", EmailId = "b@gmail.com", Password = "1234" });
                list.Add(new Users() { UserId = 2, FirstName = "Bhoomi", LastName = "Sagara", EmailId = "bs@gmail.com", Password = "12345" });
                var display = list.Where(a => a.UserId == userModel.UserId && a.Password == userModel.Password).FirstOrDefault();
                if (display == null)
                {
                    return "InCorrect UserName and Password";
                }
                return "Correct UserName and Password,Welcome";
            }
        }
    }
}
