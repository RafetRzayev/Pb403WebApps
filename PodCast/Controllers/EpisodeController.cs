using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodCast.DataContext;
using PodCast.Models;

namespace PodCast.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public EpisodeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var episodes = _dbContext.Episodes
                .Include(x => x.Speaker)
                .ThenInclude(x => x!.SpeakerProfessions)
                .ThenInclude(x => x.Profession)
                .Take(2)
                .ToList();
            var trendingEpisodes = _dbContext.Episodes.Take(2).ToList();
            var model = new EpisodeViewModel
            {
                Episodes = episodes,
                TrendingEpisodes = trendingEpisodes
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var episode = _dbContext.Episodes.FirstOrDefault(x=>x.Id == id);

            if (episode == null)
                return NotFound();

            var relatedEpisodes = _dbContext.Episodes.Skip(2).ToList();

            var model = new EpisodeDetailsViewModel
            {
                Episode = episode,
                RelatedEpisodes = relatedEpisodes
            };

            return View(model);
        }
    }
}
