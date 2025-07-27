using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDataExamples()
        {
            ViewData["message"] = "Hello from ViewData!";
            TempData["messageTemp"] = "Hello from Tempdata!";
            ViewBag.Message1 = "Hello from ViewBag!";

            return RedirectToAction("Index");
        }

        public IActionResult RedirectExample()
        {
            return RedirectToAction("Index","Student");
        }
    }
}