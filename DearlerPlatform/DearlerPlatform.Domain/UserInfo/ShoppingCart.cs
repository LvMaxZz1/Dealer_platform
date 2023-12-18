using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class ShoppingCart
{
    public  int Id { get; set; }

    public string CartGuid { get; set; } = null!;

    public string CustomerNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public int ProductNum { get; set; }

    public bool CartSelected { get; set; }
}
