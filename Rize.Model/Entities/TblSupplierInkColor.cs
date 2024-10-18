using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierInkColor
{
    public int InkColInkColorId { get; set; }

    public int SupSupplierId { get; set; }

    public string? SupInkColCode { get; set; }

    public virtual TblInkColor InkColInkColor { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;
}
