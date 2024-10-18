using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductTheme
{
    public int ProductThemeId { get; set; }

    public int ThemeId { get; set; }

    public int ProductId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public bool Active { get; set; }

    public int? ParentThemeId { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual Theme Theme { get; set; } = null!;
}
