using Microsoft.AspNetCore.Mvc.RazorPages;
using ShoppingCartApp.Models;

namespace ShoppingCartApp.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, ImageUrl = "laptop.png" },
                // Add more products as needed
            };
        }
    }
}
