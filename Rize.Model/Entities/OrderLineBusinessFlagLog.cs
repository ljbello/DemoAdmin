using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLineBusinessFlagLog
{
    public int OrderLineId { get; set; }

    public string MatchType { get; set; } = null!;

    public bool IsForBusiness { get; set; }

    public int? PreviewVersion { get; set; }

    public string? ParsedText { get; set; }

    public DateTime CreatedDate { get; set; }
}
