using AutoMapper;
using DearlerPlatform.Core;
using DearlerPlatform.Core.Repository;
using DearlerPlatform.Domain;
using DearlerPlatform.Service.ProductApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Service.ProductApp;

/// <summary>
/// 产品服务相关类
/// </summary>
public partial class ProductService : IProductService
{
   

    /// <summary>
    /// 自动注入对应仓储
    /// </summary>
    /// <param name="productRepo"></param>
    /// <param name="productPhotoRepo"></param>
    /// <param name="productSaleRepo"></param>
    /// <param name="productSaleAreaDiffRepo"></param>
    /// <param name="mapper"></param>
    public ProductService(IRepository<Product> productRepo,
      IRepository<ProductPhoto> productPhotoRepo,
      IRepository<ProductSale> productSaleRepo,
      IRepository<ProductSaleAreaDiff> productSaleAreaDiffRepo,
      IMapper mapper)
    {
        ProductRepo = productRepo;
        ProductPhotoRepo = productPhotoRepo;
        ProductSaleRepo = productSaleRepo;
        ProductSaleAreaDiffRepo = productSaleAreaDiffRepo;
        this.mapper = mapper;
    }

    public IRepository<Product> ProductRepo { get; }
    public IRepository<ProductPhoto> ProductPhotoRepo { get; }
    public IRepository<ProductSale> ProductSaleRepo { get; }
    public IRepository<ProductSaleAreaDiff> ProductSaleAreaDiffRepo { get; }
    public IMapper mapper { get; }

    /// <summary>
    /// 获得视图模型并且分页
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProductDto>> GetProductDto(PageWithSortDto pageWithSortDto)
    {
        pageWithSortDto.Sort ??= "ProductName";
        /* 
         linq语句查询数据并排序
          [from item in list]： 从list集合中获取每一条数据
          [ orderby p.GetType().GetProperty(sort).GetValue(p)]：排序，从item中通过反射获取列的值进行排序判断
          [ select item]：返回需要的数据，可以是item本身，也可以是另外重组值
         */

        // var products = (from p in (await ProductRepo.GetListAsync())
        //                 orderby p.GetType().GetProperty(sort).GetValue(p) descending
        //                 select p).Skip(skipNum).Take(PageSize).ToList();

        var products = (await ProductRepo.GetListAsync(pageWithSortDto));
        // 领域模型 转 视图模型
        var dtos = mapper.Map<List<ProductDto>>(products);
        var productPhotos = await GetProductPhotosByProductNo(products.Select(m => m.ProductNo).ToArray());
        var productSales = await GetProductSalesByProductNo(products.Select(m => m.ProductNo).ToArray());
        dtos.ForEach(p =>
        {
            p.ProductPhoto = productPhotos.FirstOrDefault(m => m.ProductNo == p.ProductNo);
            p.ProductSale = productSales.FirstOrDefault(m => m.ProductNo == p.ProductNo);
            // var productSale = productSales.FirstOrDefault(m=>m.ProductNo == p.ProductNo);
        });
        return dtos;
    }
}
