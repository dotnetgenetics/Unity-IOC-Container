using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimGeography
{
    public int GeographyKey { get; set; }

    public string GeographyType { get; set; } = null!;

    public string ContinentName { get; set; } = null!;

    public string? CityName { get; set; }

    public string? StateProvinceName { get; set; }

    public string? RegionCountryName { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<DimCustomer> DimCustomers { get; set; } = new List<DimCustomer>();

    public virtual ICollection<DimSalesTerritory> DimSalesTerritories { get; set; } = new List<DimSalesTerritory>();

    public virtual ICollection<DimStore> DimStores { get; set; } = new List<DimStore>();
}
