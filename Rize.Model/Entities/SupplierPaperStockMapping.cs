using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierPaperStockMapping
{
    public int SupplierPaperStockMappingId { get; set; }

    public int PaperStockId { get; set; }

    public int SupplierId { get; set; }

    public int PaperStockFinishId { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
