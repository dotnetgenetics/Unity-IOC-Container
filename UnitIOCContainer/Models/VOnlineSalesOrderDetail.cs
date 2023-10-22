using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class VOnlineSalesOrderDetail
{
    public string OrderNumber { get; set; } = null!;

    public int? LineNumber { get; set; }

    public string? Product { get; set; }
}
