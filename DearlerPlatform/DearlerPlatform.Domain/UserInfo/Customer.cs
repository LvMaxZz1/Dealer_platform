using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class Customer
{
    public  int Id { get; set; }

    public string CustomerNo { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string FirstAreaNo { get; set; } = null!;

    public string FirstAreaName { get; set; } = null!;

    public string AreaNo { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string Province { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string BankAccount { get; set; } = null!;

    public string BankNo { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string Ein { get; set; } = null!;

    public string CustomerNote { get; set; } = null!;

    public string? OwnerWorkerNo { get; set; }

    public string? OwnerWorkerName { get; set; }

    public string? OwnerWorkerTel { get; set; }

    public string? OpenId { get; set; }

    public string? HeadImgUrl { get; set; }
}
