using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PagePageGroup
{
    public string PageContentId { get; set; } = null!;

    public int SiteId { get; set; }

    public string PageDesignAreaId { get; set; } = null!;

    public string PageDesignGroupId { get; set; } = null!;

    public virtual PageDesignArea PageDesignArea { get; set; } = null!;

    public virtual PageDesignGroup PageDesignGroup { get; set; } = null!;
}
