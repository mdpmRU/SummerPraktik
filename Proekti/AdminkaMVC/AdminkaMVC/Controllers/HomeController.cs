using AdminkaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdminkaMVC.Controllers
{
    public class HomeController : Controller
    {
        static bool isAdmin = false;
        List<loginUser> loginUsers;
        static public bool AdminStatus = false;
        private readonly ILogger<HomeController> _logger;
        String connectionString = @"Data Source=LAPTOP-AP4IS4GE;Initial Catalog=IntMag;Integrated Security=True";
        class loginUser
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public int Role { get; set; }
        }
        public void getUsers()
        {
            loginUsers = new List<loginUser>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand("Select Login, Password, Role from Users", sqlConnection);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    loginUsers.Add(new loginUser
                    {
                        Login = reader.GetString(0).Trim(),
                        Password = reader.GetString(1).Trim(),
                        Role = reader.GetInt32(2)
                    });
                }
                sqlConnection.Close();
            }
        }
        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            ViewBag.isAdmin = "";
            bool isSuccess = false;
            AdminStatus = false;

            foreach (loginUser user in loginUsers)
            {
                isSuccess = user.Login == login;
                isSuccess &= user.Password == password;

                if (isSuccess)
                {
                    if (user.Role == 1)
                    {
                        ViewBag.isAdmin = "admin";
                        AdminStatus = true;
                        return RedirectToAction("Select_Product", "Main");
                    }
                    if (user.Role == 10)
                    {
                        ViewBag.isAdmin = "user";
                        AdminStatus = true;
                        return RedirectToAction("Select_Product", "Main");
                    }

                }
            }
            ViewBag.errorMessage = "Не удалось войти в аккаунт, проверте введенные данные";
            return View();
        }
        //Users

        public HomeController(ILogger<HomeController> logger)
        {
            ViewBag.isAdmin = "";
            getUsers();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
