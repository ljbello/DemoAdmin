using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MatchBackReport
{
    public Guid ReportId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual ICollection<MatchBackReportsUserDatum> MatchBackReportsUserData { get; set; } = new List<MatchBackReportsUserDatum>();
}
