using vanmaresqlapp.Models;

namespace vanmaresqlapp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}