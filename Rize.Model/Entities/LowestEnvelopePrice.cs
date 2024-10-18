using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class LowestEnvelopePrice
{
    public int ProductId { get; set; }

    public decimal? EnvelopeCost { get; set; }

    public int StoreId { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
