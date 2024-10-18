using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Theme
{
    public int ThemeId { get; set; }

    public string ThemeName { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int? ParentThemeId { get; set; }

    public virtual ICollection<ProductTheme> ProductThemes { get; set; } = new List<ProductTheme>();
}
