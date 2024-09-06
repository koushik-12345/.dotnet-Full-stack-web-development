using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        SalesDbContext _context;

        public HomeController(SalesDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> prodList = _context.Products.ToList();
            return View(prodList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod)
        {
            _context.Products.Add(prod);
            _context.SaveChanges();
            return RedirectToAction("Index");
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
