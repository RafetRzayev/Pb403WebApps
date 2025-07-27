using PodCast.DataContext.Entities;

namespace PodCast.Models
{
    public class EpisodeViewModel
    {
        public List<Episode> Episodes { get; set; } = [];
        public List<Episode> TrendingEpisodes { get; set; } = [];
    }
}
