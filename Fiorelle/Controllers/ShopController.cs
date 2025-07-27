using Fiorelle.DataContext;
using Fiorelle.DataContext.Entities;
using Fiorelle.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiorelle.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.ToList();

            var shopViewModel = new ShopViewModel
            {
                Categories = categories,
                Products = products
            };

            return View(shopViewModel);
        }
    }
}
