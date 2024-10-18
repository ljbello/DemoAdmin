using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblHorizontalAlignmentType
{
    public int HorAliTypHorizontalAlignmentId { get; set; }

    public string HorAliTypAlignmentName { get; set; } = null!;

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<TblLayoutArea> TblLayoutAreas { get; set; } = new List<TblLayoutArea>();
}
