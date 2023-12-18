using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DearlerPlatform.Domain;
using DearlerPlatform.Service.ProductApp.Dto;

namespace DearlerPlatform.Service
{
    public class DealerPlatformProfile : Profile
    {
        public DealerPlatformProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<ProductSale,ProductDto>().ReverseMap();
            CreateMap<ProductPhoto,ProductDto>().ReverseMap();
            CreateMap<ProductSaleAreaDiff,ProductDto>().ReverseMap();
        }
    }
}