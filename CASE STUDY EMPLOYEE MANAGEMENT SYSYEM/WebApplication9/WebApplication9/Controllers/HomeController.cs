using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EmployeeDbContext _db1;
        public HomeController(EmployeeDbContext db)
        {
            _db1 = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User obj)
        {
            _db1.Users.Add(obj);
            _db1.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {

            if (email == "koushik@gmail.com" && password == "koushik")
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                ViewData["result"] = "Invalid UserId  & Password";

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 2, Location = ResponseCacheLocation.None, NoStore = false)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
