using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageAddRotator
{
    public string PageContentId { get; set; } = null!;

    public int SiteId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? NavigateUrl { get; set; }

    public string? AlternateText { get; set; }

    public int Sequence { get; set; }

    public int? Impressions { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public bool Active { get; set; }
}
