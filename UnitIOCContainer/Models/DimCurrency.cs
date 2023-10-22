using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimCurrency
{
    public int CurrencyKey { get; set; }

    public string CurrencyLabel { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public string CurrencyDescription { get; set; } = null!;

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<FactExchangeRate> FactExchangeRates { get; set; } = new List<FactExchangeRate>();

    public virtual ICollection<FactInventory> FactInventories { get; set; } = new List<FactInventory>();

    public virtual ICollection<FactOnlineSale> FactOnlineSales { get; set; } = new List<FactOnlineSale>();

    public virtual ICollection<FactSale> FactSales { get; set; } = new List<FactSale>();

    public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; } = new List<FactSalesQuotum>();

    public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; } = new List<FactStrategyPlan>();
}
