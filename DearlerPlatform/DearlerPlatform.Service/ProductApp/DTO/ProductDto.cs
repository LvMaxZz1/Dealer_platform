using DearlerPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Service.ProductApp.DTO
{
    /// <summary>
    /// 产品视图模型
    /// </summary>
    public class ProductDto
    {
        public int Id { get; set; }

        public string SysNo { get; set; } = null!;

        public string ProductNo { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string TypeNo { get; set; } = null!;

        public string TypeName { get; set; } = null!;

        public string ProductPp { get; set; } = null!;

        public string ProductXh { get; set; } = null!;

        public string ProductCz { get; set; } = null!;

        public string ProductHb { get; set; } = null!;

        public string ProductHd { get; set; } = null!;

        public string ProductGy { get; set; } = null!;

        public string ProductHs { get; set; } = null!;

        public string ProductMc { get; set; } = null!;

        public string ProductDj { get; set; } = null!;

        public string ProductCd { get; set; } = null!;

        public string ProductGg { get; set; } = null!;

        public string ProductYs { get; set; } = null!;

        public string UnitNo { get; set; } = null!;

        public string UnitName { get; set; } = null!;

        public string ProductNote { get; set; } = null!;

        public string ProductBzgg { get; set; } = null!;

        public string BelongTypeNo { get; set; } = null!;

        public string BelongTypeName { get; set; } = null!;

        public string ProductPhotoUrl { get; set; } = null!;

        public string? StockNo { get; set; }

        public double SalePrice { get; set; }

        public string AreaNo { get; set; } = null!;

        public string FirstAreaNo { get; set; } = null!;

        public double DiffPrice { get; set; }
        public ProductPhoto ProductPhoto { get; set; }
        public ProductSale ProductSale { get; set; }
    }
}
