using PodCast.DataContext.Entities;

namespace PodCast.Models
{
    public class EpisodeDetailsViewModel
    {
        public Episode? Episode { get; set; }
        public List<Episode> RelatedEpisodes { get; set; } = [];
    }
}
