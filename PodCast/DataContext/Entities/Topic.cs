namespace PodCast.DataContext.Entities
{
    public class Topic : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public List<Episode> Episodes { get; set; } = [];
    }
}