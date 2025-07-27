using Microsoft.AspNetCore.Mvc;
using MvcDemoWithDb.DataContext;
using MvcDemoWithDb.Models;
using System.Diagnostics;

namespace MvcDemoWithDb.Controllers
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
            var students = _dbContext.Students.ToList();
            //ViewBag.Students = students;
            ViewData["Students"] = students;

            return View();
        }
    }      
}
