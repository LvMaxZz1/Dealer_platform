using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class ProductPhoto
{
    public  int Id { get; set; }

    public string? SysNo { get; set; }

    public string ProductNo { get; set; } = null!;

    public string ProductPhotoUrl { get; set; } = null!;
}
