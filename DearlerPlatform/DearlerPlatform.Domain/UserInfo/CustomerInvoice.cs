using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class CustomerInvoice
{
    public  int Id { get; set; }

    public string CustomerNo { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public string InvoiceEin { get; set; } = null!;

    public string InvoiceBank { get; set; } = null!;

    public string InvoiceAccount { get; set; } = null!;

    public string InvoiceAddress { get; set; } = null!;

    public string InvoicePhone { get; set; } = null!;
}
