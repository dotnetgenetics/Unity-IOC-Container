using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class VCustomerOrder
{
    public string ProductCategoryName { get; set; } = null!;

    public string ProductSubcategory { get; set; } = null!;

    public string? Product { get; set; }

    public int CustomerKey { get; set; }

    public string? Region { get; set; }

    public int? Age { get; set; }

    public string IncomeGroup { get; set; } = null!;

    public int CalendarYear { get; set; }

    public int FiscalYear { get; set; }

    public int Month { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int? LineNumber { get; set; }

    public int Quantity { get; set; }

    public decimal Amount { get; set; }
}
