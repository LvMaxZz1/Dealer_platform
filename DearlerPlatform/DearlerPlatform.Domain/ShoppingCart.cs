using System;
using System.Collections.Generic;

#nullable disable

namespace DearlerPlatform.Domain
{
    public partial class ShoppingCart
    {
        public int Id { get; set; }
        public string CartGuid { get; set; }
        public string CustomerNo { get; set; }
        public string ProductNo { get; set; }
        public int ProductNum { get; set; }
        public bool CartSelected { get; set; }
    }
}
