using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class WebPageTheme
{
    public int ThemeId { get; set; }

    public int SiteId { get; set; }

    public string ThemeName { get; set; } = null!;

    public virtual ICollection<PageContent> PageContents { get; set; } = new List<PageContent>();
}
