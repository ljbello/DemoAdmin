using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageDesignGroup
{
    public string PageDesignGroupId { get; set; } = null!;

    public int SiteId { get; set; }

    public string DesignGroupName { get; set; } = null!;

    public int Sequence { get; set; }

    public virtual ICollection<PagePageGroup> PagePageGroups { get; set; } = new List<PagePageGroup>();
}
