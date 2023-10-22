using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimDate
{
    public DateTime Datekey { get; set; }

    public string FullDateLabel { get; set; } = null!;

    public string DateDescription { get; set; } = null!;

    public int CalendarYear { get; set; }

    public string CalendarYearLabel { get; set; } = null!;

    public int CalendarHalfYear { get; set; }

    public string CalendarHalfYearLabel { get; set; } = null!;

    public int CalendarQuarter { get; set; }

    public string? CalendarQuarterLabel { get; set; }

    public int CalendarMonth { get; set; }

    public string CalendarMonthLabel { get; set; } = null!;

    public int CalendarWeek { get; set; }

    public string CalendarWeekLabel { get; set; } = null!;

    public int CalendarDayOfWeek { get; set; }

    public string CalendarDayOfWeekLabel { get; set; } = null!;

    public int FiscalYear { get; set; }

    public string FiscalYearLabel { get; set; } = null!;

    public int FiscalHalfYear { get; set; }

    public string FiscalHalfYearLabel { get; set; } = null!;

    public int FiscalQuarter { get; set; }

    public string FiscalQuarterLabel { get; set; } = null!;

    public int FiscalMonth { get; set; }

    public string FiscalMonthLabel { get; set; } = null!;

    public string IsWorkDay { get; set; } = null!;

    public int IsHoliday { get; set; }

    public string HolidayName { get; set; } = null!;

    public string? EuropeSeason { get; set; }

    public string? NorthAmericaSeason { get; set; }

    public string? AsiaSeason { get; set; }

    public virtual ICollection<FactExchangeRate> FactExchangeRates { get; set; } = new List<FactExchangeRate>();

    public virtual ICollection<FactInventory> FactInventories { get; set; } = new List<FactInventory>();

    public virtual ICollection<FactItmachine> FactItmachines { get; set; } = new List<FactItmachine>();

    public virtual ICollection<FactItsla> FactItslas { get; set; } = new List<FactItsla>();

    public virtual ICollection<FactOnlineSale> FactOnlineSales { get; set; } = new List<FactOnlineSale>();

    public virtual ICollection<FactSale> FactSales { get; set; } = new List<FactSale>();

    public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; } = new List<FactSalesQuotum>();

    public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; } = new List<FactStrategyPlan>();
}
