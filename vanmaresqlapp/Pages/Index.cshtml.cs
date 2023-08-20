using Microsoft.AspNetCore.Mvc.RazorPages;
using vanmaresqlapp.Models;
using vanmaresqlapp.Services;

namespace vanmaresqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        public void OnGet()
        {
            Products = _productService.GetProducts();
        }

    }

}