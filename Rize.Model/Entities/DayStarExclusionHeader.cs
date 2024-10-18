using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DayStarExclusionHeader
{
    public int DayStarExclusionHeaderId { get; set; }

    public string Description { get; set; } = null!;

    public DateOnly ExclusionDate { get; set; }

    public virtual ICollection<DayStarExclusionDetail> DayStarExclusionDetails { get; set; } = new List<DayStarExclusionDetail>();
}
