using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class FactOnlineSale
{
    public int OnlineSalesKey { get; set; }

    public DateTime DateKey { get; set; }

    public int StoreKey { get; set; }

    public int ProductKey { get; set; }

    public int PromotionKey { get; set; }

    public int CurrencyKey { get; set; }

    public int CustomerKey { get; set; }

    public string SalesOrderNumber { get; set; } = null!;

    public int? SalesOrderLineNumber { get; set; }

    public int SalesQuantity { get; set; }

    public decimal SalesAmount { get; set; }

    public int ReturnQuantity { get; set; }

    public decimal? ReturnAmount { get; set; }

    public int? DiscountQuantity { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal TotalCost { get; set; }

    public decimal? UnitCost { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual DimCurrency CurrencyKeyNavigation { get; set; } = null!;

    public virtual DimCustomer CustomerKeyNavigation { get; set; } = null!;

    public virtual DimDate DateKeyNavigation { get; set; } = null!;

    public virtual DimProduct ProductKeyNavigation { get; set; } = null!;

    public virtual DimPromotion PromotionKeyNavigation { get; set; } = null!;

    public virtual DimStore StoreKeyNavigation { get; set; } = null!;
}
