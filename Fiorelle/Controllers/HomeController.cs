using Fiorelle.DataContext;
using Fiorelle.DataContext.Entities;
using Fiorelle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fiorelle.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImages = _dbContext.SliderImages.ToList();
            var sliderContent = _dbContext.SliderContents.FirstOrDefault();
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Take(4).ToList();
            ViewBag.ProductCount = _dbContext.Products.Count();

            var homeViewModel = new HomeViewModel
            {
                SliderImages = sliderImages,
                SliderContent = sliderContent,
                Categories = categories,
                Products = products
            };

            return View(homeViewModel);
        }

        //public IActionResult Partial(int skip)
        //{
        //    var products = _dbContext.Products.Skip(skip).Take(4).ToList();

        //    return PartialView("_ProductsPartialOnly", products);
        //} 


        public IActionResult Partial(int skip)
        {
            var products = _dbContext.Products.Include(x => x.Category).Skip(skip).Take(4).ToList();

            return Json(products);
        }
    }
}
