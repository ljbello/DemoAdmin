using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierPaperStock
{
    public int SupplierId { get; set; }

    public int PaperStockId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }
}
