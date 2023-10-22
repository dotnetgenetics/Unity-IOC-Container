using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimProductSubcategory
{
    public int ProductSubcategoryKey { get; set; }

    public string? ProductSubcategoryLabel { get; set; }

    public string ProductSubcategoryName { get; set; } = null!;

    public string? ProductSubcategoryDescription { get; set; }

    public int? ProductCategoryKey { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<DimProduct> DimProducts { get; set; } = new List<DimProduct>();

    public virtual DimProductCategory? ProductCategoryKeyNavigation { get; set; }
}
