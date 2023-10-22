using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class FactItsla
{
    public int Itslakey { get; set; }

    public DateTime DateKey { get; set; }

    public int StoreKey { get; set; }

    public int MachineKey { get; set; }

    public int OutageKey { get; set; }

    public DateTime OutageStartTime { get; set; }

    public DateTime OutageEndTime { get; set; }

    public int DownTime { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual DimDate DateKeyNavigation { get; set; } = null!;

    public virtual DimMachine MachineKeyNavigation { get; set; } = null!;

    public virtual DimOutage OutageKeyNavigation { get; set; } = null!;

    public virtual DimStore StoreKeyNavigation { get; set; } = null!;
}
