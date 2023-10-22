using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class FactStrategyPlan
{
    public int StrategyPlanKey { get; set; }

    public DateTime Datekey { get; set; }

    public int EntityKey { get; set; }

    public int ScenarioKey { get; set; }

    public int AccountKey { get; set; }

    public int CurrencyKey { get; set; }

    public int? ProductCategoryKey { get; set; }

    public decimal Amount { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual DimAccount AccountKeyNavigation { get; set; } = null!;

    public virtual DimCurrency CurrencyKeyNavigation { get; set; } = null!;

    public virtual DimDate DatekeyNavigation { get; set; } = null!;

    public virtual DimEntity EntityKeyNavigation { get; set; } = null!;

    public virtual DimProductCategory? ProductCategoryKeyNavigation { get; set; }

    public virtual DimScenario ScenarioKeyNavigation { get; set; } = null!;
}
