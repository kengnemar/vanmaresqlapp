using Microsoft.AspNetCore.Mvc.RazorPages;
using vanmaresqlapp.Models;
using vanmaresqlapp.Services;

namespace vanmaresqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();
        }

    }

}