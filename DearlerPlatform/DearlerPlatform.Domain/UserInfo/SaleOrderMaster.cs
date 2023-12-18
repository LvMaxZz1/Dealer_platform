using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class SaleOrderMaster
{
    public  int Id { get; set; }

    public string SaleOrderNo { get; set; } = null!;

    public string CustomerNo { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public DateTime InputDate { get; set; }

    public string StockNo { get; set; } = null!;

    public string EditUserNo { get; set; } = null!;

    public DateTime DeliveryDate { get; set; }

    public string? Remark { get; set; }
}
