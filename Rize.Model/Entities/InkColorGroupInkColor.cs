using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class InkColorGroupInkColor
{
    public int InkColorGroupId { get; set; }

    public int InkColorId { get; set; }

    public int? Position { get; set; }

    public virtual TblInkColor InkColor { get; set; } = null!;

    public virtual InkColorGroup InkColorGroup { get; set; } = null!;
}
