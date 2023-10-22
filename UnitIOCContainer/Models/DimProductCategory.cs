using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimProductCategory
{
    public int ProductCategoryKey { get; set; }

    public string? ProductCategoryLabel { get; set; }

    public string ProductCategoryName { get; set; } = null!;

    public string ProductCategoryDescription { get; set; } = null!;

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<DimProductSubcategory> DimProductSubcategories { get; set; } = new List<DimProductSubcategory>();

    public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; } = new List<FactStrategyPlan>();
}
