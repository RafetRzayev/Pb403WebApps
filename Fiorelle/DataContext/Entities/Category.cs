namespace Fiorelle.DataContext.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;

        public int CategoryId {  get; set; }
        public Category? Category { get; set; }
    }
}
