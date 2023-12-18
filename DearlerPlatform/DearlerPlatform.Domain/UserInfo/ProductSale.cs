using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class ProductSale
{
    public  int Id { get; set; }

    public string SysNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string? StockNo { get; set; }

    public double SalePrice { get; set; }
}
