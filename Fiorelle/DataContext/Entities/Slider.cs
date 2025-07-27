namespace Fiorelle.DataContext.Entities
{
    public class SliderImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
    }

    public class SliderContent
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
    }
}
