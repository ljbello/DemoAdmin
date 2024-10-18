using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CreditCardBinRange
{
    public int CreditCardBinRangeId { get; set; }

    public long LowRange { get; set; }

    public long HighRange { get; set; }

    public string Type { get; set; } = null!;

    public string Country { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
