using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CmscontentArea
{
    public int ContentAreaId { get; set; }

    public string Name { get; set; } = null!;

    public string HtmlContent { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public int ModifiedBy { get; set; }

    public int PageId { get; set; }

    public int Position { get; set; }

    public bool IsVisible { get; set; }

    public int PageVersion { get; set; }

    public virtual Cmspage Page { get; set; } = null!;
}
