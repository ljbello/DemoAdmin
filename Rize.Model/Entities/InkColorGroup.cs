using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class InkColorGroup
{
    public int InkColorGroupId { get; set; }

    public string Name { get; set; } = null!;

    public int ProductionTypeId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<InkColorGroupInkColor> InkColorGroupInkColors { get; set; } = new List<InkColorGroupInkColor>();

    public virtual ProductionType ProductionType { get; set; } = null!;

    public virtual ICollection<TblChristmasCard> TblChristmasCards { get; set; } = new List<TblChristmasCard>();
}
