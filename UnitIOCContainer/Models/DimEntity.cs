using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimEntity
{
    public int EntityKey { get; set; }

    public string? EntityLabel { get; set; }

    public int? ParentEntityKey { get; set; }

    public string? ParentEntityLabel { get; set; }

    public string? EntityName { get; set; }

    public string? EntityDescription { get; set; }

    public string? EntityType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Status { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; } = new List<FactStrategyPlan>();
}
