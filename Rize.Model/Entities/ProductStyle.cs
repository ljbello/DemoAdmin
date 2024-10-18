using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductStyle
{
    public int ProductStyleId { get; set; }

    public int ProductId { get; set; }

    public int StyleId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual Style Style { get; set; } = null!;
}
