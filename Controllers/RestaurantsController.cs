using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Dtos;
using ProductAPI.Dtos.Products;
using ProductAPI.Dtos.Restaurants;
using ProductAPI.Models;
using ProductAPI.Services.Interfaces;
using ProductAPI.Services.Interfaces.ProductService;
using ProductAPI.Utilities;

namespace ProductAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public RestaurantsController(IRestaurantService restaurant, IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _restaurantService = restaurant;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ResponseMessage> Get()
        {
            return await _restaurantService.GetAll();
        }
        [HttpGet("{id}")]
        public Restaurant GetById(int id)
        {
            Restaurant result = _restaurantService.GetById(id);
            return result;
        }
        [HttpPost]
        public async Task<ResponseMessage> Add(CreateRestaurantDto createRestaurantDto)
        {
            Restaurant restaurant = _mapper.Map<Restaurant>(createRestaurantDto);
            if (restaurant == null)
            {
                return new ResponseMessage()
                {
                    Message = "Product Id does not exist",
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            //Restaurant restaurant = _mapper.Map<Restaurant>(createRestaurantDto);
            return await _restaurantService.Add(restaurant);

        }
        [HttpPut]
        public async Task<ResponseMessage> Update([FromBody] UpdateRestaurantDto restaurantProductDto)
        {
            Restaurant restaurant = _mapper.Map<Restaurant>(restaurantProductDto);
            if (restaurant == null)
            {
                return new ResponseMessage()
                {
                    Message = "Product Id does not exist",
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            
            return await _restaurantService.Update(restaurant);
        }
        [HttpDelete]
        public async Task<ResponseMessage> Delete([FromRoute] int id)
        {
            Restaurant restaurant = _restaurantService.GetById(id);
            if (restaurant == null)
            {
                return new ResponseMessage()
                {
                    Message = "Restaurant..",
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            await _restaurantService.Delete(restaurant);

            return new ResponseMessage()
            {
                Message = "Restaurant silinir",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        /* [HttpPost]
         public ResponseMessage Create(CreateRestaurantDto createDto)
         {

             _restaurantService.Add

         }*/
    }
}