using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AreaType
{
    public int AreaTypeId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime EntityCreated { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();
}
