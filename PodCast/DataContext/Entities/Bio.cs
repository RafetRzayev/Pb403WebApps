namespace PodCast.DataContext.Entities
{
    public class Bio : BaseEntity
    {
        public string LogoUrl { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobileNumber1 { get; set; } = null!;
    }
}
