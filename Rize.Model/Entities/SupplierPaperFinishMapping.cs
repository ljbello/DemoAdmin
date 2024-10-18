using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierPaperFinishMapping
{
    public int SupplierPaperFinishId { get; set; }

    public int PaperFinishId { get; set; }

    public int SupplierId { get; set; }

    public virtual PaperFinish PaperFinish { get; set; } = null!;

    public virtual TblSupplier Supplier { get; set; } = null!;
}
