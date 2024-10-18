using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageContent
{
    public int PageId { get; set; }

    public string PageContentId { get; set; } = null!;

    public int SiteId { get; set; }

    public int? MasterPageId { get; set; }

    public int ThemeId { get; set; }

    public string Content { get; set; } = null!;

    public string Content2 { get; set; } = null!;

    public bool Display { get; set; }

    public string MetaTitle { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string MetaKeywords { get; set; } = null!;

    public string H1title { get; set; } = null!;

    public string? HeaderContent { get; set; }

    public string Description { get; set; } = null!;

    public DateTime Date { get; set; }

    public int CurrentState { get; set; }

    public bool Active { get; set; }

    public string Notes { get; set; } = null!;

    public int NavMenuCategoryId { get; set; }

    public bool? ShowInSitemap { get; set; }

    public string? MobileContent { get; set; }

    public virtual PageMasterPage? MasterPage { get; set; }

    public virtual WebPageTheme Theme { get; set; } = null!;
}
