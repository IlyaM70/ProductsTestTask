using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductsTestTask.Models;
using System.Diagnostics;

namespace ProductsTestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IActionResult Index(HomeViewModel model)
        {
            List<ProductCategory> products = _db.ProductCategory
                .Include(p => p.Product)
                .Include(c => c.Category)
                .ToList();
            model.Products = products;

            MakeCategoriesList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model, IFormCollection formValues)
        {
            List<ProductCategory> products = _db.ProductCategory
                .Include(p => p.Product)
                .Include(c => c.Category)
                .Where(pc=>pc.CategoryId==model.CategoryId)
                .ToList();
            model.Products = products;

            MakeCategoriesList();

            return View(model);
        }

        public void MakeCategoriesList()
        {
            List<Category> categories = _db.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
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