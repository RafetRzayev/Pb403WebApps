using Microsoft.AspNetCore.Mvc;
using PodCast.Models;
using PodCast.DataContext;
using Microsoft.EntityFrameworkCore;

namespace PodCast.Controllers
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
            var model = new HomeViewModel
            {
                Speakers = _dbContext.Speakers.ToList(),
                Topics = _dbContext.Topics.ToList(),
                Episodes = _dbContext.Episodes
                    .Include(e => e.Speaker)
                    .Include(e => e.Topic)
                    .OrderByDescending(e => e.Id)
                    .Take(2)
                    .ToList(),
                TrendingEpisodes = _dbContext.Episodes.Take(2).ToList(),
            };
            return View(model);
        }
    }
}
