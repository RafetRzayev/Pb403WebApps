using Fiorelle.DataContext.Entities;

namespace Fiorelle.Models
{
    public class HomeViewModel
    {
        public List<SliderImage> SliderImages { get; set; } = [];
        public SliderContent? SliderContent { get; set; }
        public List<Category> Categories { get; set; } = [];
        public List<Product> Products { get; set; } = [];
    }

    public class ShopViewModel
    {
        public List<Category> Categories { get; set; } = [];
        public List<Product> Products { get; set; } = [];
    }
}
