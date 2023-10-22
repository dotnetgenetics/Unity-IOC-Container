﻿using System;
using System.Collections.Generic;

namespace UnitIOCContainer.Models;

public partial class DimEmployee
{
    public int EmployeeKey { get; set; }

    public int? ParentEmployeeKey { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? Title { get; set; }

    public DateTime? HireDate { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }

    public string? MaritalStatus { get; set; }

    public string? EmergencyContactName { get; set; }

    public string? EmergencyContactPhone { get; set; }

    public bool? SalariedFlag { get; set; }

    public string? Gender { get; set; }

    public byte? PayFrequency { get; set; }

    public decimal? BaseRate { get; set; }

    public short? VacationHours { get; set; }

    public bool CurrentFlag { get; set; }

    public bool SalesPersonFlag { get; set; }

    public string? DepartmentName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Status { get; set; }

    public int? EtlloadId { get; set; }

    public DateTime? LoadDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<DimEmployee> InverseParentEmployeeKeyNavigation { get; set; } = new List<DimEmployee>();

    public virtual DimEmployee? ParentEmployeeKeyNavigation { get; set; }
}
