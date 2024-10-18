using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblVerticalAlignmentType
{
    public int VerAliTypVerticalAlignmentTypeId { get; set; }

    public string VerAliTypAlignmentName { get; set; } = null!;

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<TblLayoutArea> TblLayoutAreas { get; set; } = new List<TblLayoutArea>();
}
