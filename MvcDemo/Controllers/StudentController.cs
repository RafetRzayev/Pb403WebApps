using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = DataContext.Students;
            ViewBag.Title = "Student List";
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = DataContext.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
