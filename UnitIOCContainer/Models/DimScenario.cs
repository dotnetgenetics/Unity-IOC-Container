using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimScenario
{
    public int ScenarioKey { get; set; }

    public string ScenarioLabel { get; set; } = null!;

    public string? ScenarioName { get; set; }

    public string? ScenarioDescription { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; } = new List<FactSalesQuotum>();

    public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; } = new List<FactStrategyPlan>();
}
