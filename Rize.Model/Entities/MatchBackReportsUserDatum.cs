using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MatchBackReportsUserDatum
{
    public Guid ReportDataId { get; set; }

    public Guid ReportId { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Company { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public int? CustomerId { get; set; }

    public string? MatchType { get; set; }

    public virtual MatchBackReport Report { get; set; } = null!;
}
