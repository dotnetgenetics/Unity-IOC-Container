using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class VOnlineSalesOrder
{
    public string OrderNumber { get; set; } = null!;

    public int CustomerKey { get; set; }

    public string? Region { get; set; }

    public string IncomeGroup { get; set; } = null!;
}
