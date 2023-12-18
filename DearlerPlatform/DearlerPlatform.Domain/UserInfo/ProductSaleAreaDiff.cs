using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class ProductSaleAreaDiff
{
    public  int Id { get; set; }

    public string SysNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string StockNo { get; set; } = null!;

    public string AreaNo { get; set; } = null!;

    public string FirstAreaNo { get; set; } = null!;

    public double DiffPrice { get; set; }
}
