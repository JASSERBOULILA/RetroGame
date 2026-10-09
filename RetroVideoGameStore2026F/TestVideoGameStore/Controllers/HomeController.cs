using Microsoft.AspNetCore.Mvc;
using TestVideoGameStore.Models;
using System.Diagnostics;
using TestVideoGameStore.Data;
using Microsoft.EntityFrameworkCore;

namespace TestVideoGameStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            var applicationDBContext = _context.Products.Include(p => p.Category);
            return View("Index", await applicationDBContext.ToListAsync());
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
