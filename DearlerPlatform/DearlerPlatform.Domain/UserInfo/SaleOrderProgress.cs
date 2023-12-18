using DearlerPlatform.Domain.UserInfo;
using System;
using System.Collections.Generic;

namespace DearlerPlatform.Domain;

public partial class SaleOrderProgress
{
    public  int Id { get; set; }

    public string SaleOrderNo { get; set; } = null!;

    public string ProgressGuid { get; set; } = null!;

    public int StepSn { get; set; }

    public string StepName { get; set; } = null!;

    public DateTime StepTime { get; set; }
}
