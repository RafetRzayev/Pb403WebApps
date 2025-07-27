namespace PodCast.DataContext.Entities
{
    public class Speaker : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ProfileImagePath { get; set; } = string.Empty;
        public List<SpeakerProfession> SpeakerProfessions { get; set; } = [];
        public List<Episode> Episodes { get; set; } = [];
    }
}