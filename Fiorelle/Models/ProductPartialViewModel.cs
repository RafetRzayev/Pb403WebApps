using Fiorelle.DataContext.Entities;

namespace Fiorelle.Models
{
    public class ProductPartialViewModel
    {
        public List<Category> Categories { get; set; } = [];
        public List<Product> Products { get; set; } = [];
    }
}
