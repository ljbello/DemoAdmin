using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageMasterPage
{
    public int MasterPageId { get; set; }

    public int SiteId { get; set; }

    public string MasterPageName { get; set; } = null!;

    public virtual ICollection<PageContent> PageContents { get; set; } = new List<PageContent>();
}
