using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class SaleOrderDetail: BaseEntity
{
    public new int Id { get; set; }

    public string SaleOrderGuid { get; set; } = null!;

    public string SaleOrderNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? ProductPhotoUrl { get; set; }

    public string CustomerNo { get; set; } = null!;

    public DateTime InputDate { get; set; }

    public int OrderNum { get; set; }

    public double BasePrice { get; set; }

    public double DiffPrice { get; set; }

    public double SalePrice { get; set; }
}
