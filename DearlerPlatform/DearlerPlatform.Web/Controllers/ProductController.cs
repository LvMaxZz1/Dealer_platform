using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DearlerPlatform.Core;
using DearlerPlatform.Service.ProductApp;
using DearlerPlatform.Service.ProductApp.Dto;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DearlerPlatform.Web.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductController : BaseController
    {
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }

        public IProductService ProductService { get; }
        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetProductDtosAsync(string? sort, int pageIndex = 1, int pageSize = 30, OrderType orderType = OrderType.Asc)
        {
            return await ProductService.GetProductDto(new PageWithSortDto(){
                Sort = sort,
                PageIndex = pageIndex,
                PageSize= pageSize,
                OrderType = orderType
            });
        }
    }
}