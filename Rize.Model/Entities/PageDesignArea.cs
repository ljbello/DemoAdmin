using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageDesignArea
{
    public string PageDesignAreaId { get; set; } = null!;

    public string DesignAreaName { get; set; } = null!;

    public int Sequence { get; set; }

    public virtual ICollection<PagePageGroup> PagePageGroups { get; set; } = new List<PagePageGroup>();
}
