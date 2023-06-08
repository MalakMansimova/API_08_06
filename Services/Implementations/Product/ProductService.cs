using ProductAPI.DAL;
using ProductAPI.Services.Implementations.Base;
using ProductAPI.Services.Interfaces.ProductService;

namespace ProductAPI.Services.Implementations.Product
{
    public class ProductService : BaseService<Models.Product>, IProductService
    {
        public ProductService(AppDbContext context) : base(context)
        {
        }
    }
}
