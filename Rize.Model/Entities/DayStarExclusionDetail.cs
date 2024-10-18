using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DayStarExclusionDetail
{
    public long DayStarExclusionDetailId { get; set; }

    public int DayStarExclusionHeaderId { get; set; }

    public long CustomerId { get; set; }

    public virtual DayStarExclusionHeader DayStarExclusionHeader { get; set; } = null!;
}
