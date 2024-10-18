using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AreaName
{
    public int AreaNameId { get; set; }

    public string AreaName1 { get; set; } = null!;

    public virtual ICollection<AreaDefault> AreaDefaults { get; set; } = new List<AreaDefault>();

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();
}
