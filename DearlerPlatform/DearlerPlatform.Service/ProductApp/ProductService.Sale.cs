using DearlerPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Service.ProductApp
{
    public partial class ProductService
    {
        /// <summary>
        /// 根据产品Id获得产品价格
        /// </summary>
        /// <param name="productNos"></param>
        /// <returns></returns>
        public async Task<List<ProductSale>> GetProductSalesByProductNo(params string[] productNos)
        {
            return await ProductSaleRepo.GetListAsync(m => productNos.Contains(m.ProductNo));
        }
    }
}
