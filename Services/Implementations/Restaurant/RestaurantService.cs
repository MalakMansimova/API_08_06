using ProductAPI.DAL;
using ProductAPI.Services.Implementations.Base;
using ProductAPI.Services.Interfaces;

namespace ProductAPI.Services.Implementations.Restaurant
{
    public class RestaurantService : BaseService<Models.Restaurant>, IRestaurantService
    {
        public RestaurantService(AppDbContext context) : base(context)
        {
        }
    }
}
