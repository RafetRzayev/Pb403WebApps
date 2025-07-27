using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
