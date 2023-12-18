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
        /// 根据产品id获得产品照片
        /// </summary>
        /// <param name="productNos"></param>
        /// <returns></returns>
        public async Task<List<ProductPhoto>> GetProductPhotosByProductNo(params string[] productNos)
        {
            return await ProductPhotoRepo.GetListAsync(m => productNos.Contains(m.ProductNo));
        }
    }
}
