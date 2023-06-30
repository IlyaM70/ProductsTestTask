using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProductsTestTask.Models
{
    public class HomeViewModel
    {
        public List<ProductCategory> Products { get; set; }
        public int CategoryId { get; set; }

        public HomeViewModel()
        {
            Products = new List<ProductCategory>();
            CategoryId = 0;
        }
    }
}
