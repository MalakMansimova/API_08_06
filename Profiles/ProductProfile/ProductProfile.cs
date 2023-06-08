using AutoMapper;
using ProductAPI.Dtos.Products;
using ProductAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace ProductAPI.Profiles.ProductProfile
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<Product, GetProductDto>();
            CreateMap<UpdateProductDto,Product>();
        }
    }
}
