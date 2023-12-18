using AutoMapper;
using DearlerPlatform.Domain;
using DearlerPlatform.Service.ProductApp.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Service
{
    /// <summary>
    /// 实体映射
    /// </summary>
    public class DearlerPlatformProfile :Profile
    {
        public DearlerPlatformProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductSale, ProductDto>().ReverseMap();
            CreateMap<ProductPhoto, ProductDto>().ReverseMap();
            CreateMap<ProductSaleAreaDiff, ProductDto>().ReverseMap();
        }
    }
}
