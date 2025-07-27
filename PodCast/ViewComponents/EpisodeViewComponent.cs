using Microsoft.AspNetCore.Mvc;
using PodCast.DataContext;
using PodCast.DataContext.Entities;

namespace PodCast.ViewComponents
{
    public class EpisodeViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public EpisodeViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(List<Episode> episodes)
        {
            //var episodes = _dbContext.Episodes.ToList();

            return View(episodes);
        }
    }
}
