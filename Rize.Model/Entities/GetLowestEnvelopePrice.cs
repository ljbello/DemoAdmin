using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetLowestEnvelopePrice
{
    public int ProductId { get; set; }

    public decimal? EnvelopeCost { get; set; }

    public int StoreId { get; set; }
}
