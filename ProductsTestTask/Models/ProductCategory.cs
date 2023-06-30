namespace ProductsTestTask.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ProductCategory(int id, int productId, int categoryId)
        {
            Id = id;
            ProductId = productId;
            CategoryId = categoryId;
        }

        public ProductCategory(int productId, int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }
    }
}
