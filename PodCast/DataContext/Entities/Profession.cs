namespace PodCast.DataContext.Entities
{
    public class Profession : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<SpeakerProfession> SpeakerProfessions { get; set; } = [];
    }
}