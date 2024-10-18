using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierEmailExtractor
{
    public int SupplierEmailExtractorId { get; set; }

    public int SupplierId { get; set; }

    public bool InvoiceFile { get; set; }

    public string? FilterValue { get; set; }

    public string? EmailPath { get; set; }

    public bool AppendDate { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
