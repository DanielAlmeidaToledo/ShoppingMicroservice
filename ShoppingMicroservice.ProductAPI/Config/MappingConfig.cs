using AutoMapper;
using ShoppingMicroservice.ProductAPI.Data.ValueObjects;
using ShoppingMicroservice.ProductAPI.Model;

namespace ShoppingMicroservice.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
