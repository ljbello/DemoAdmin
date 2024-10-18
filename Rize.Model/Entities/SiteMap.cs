using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SiteMap
{
    public int SiteMapId { get; set; }

    public string SiteMapName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int? ThemeId { get; set; }

    public int? MasterPageId { get; set; }

    public int? Content { get; set; }

    public bool? Active { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public string? H1title { get; set; }

    public string? Description { get; set; }
}
