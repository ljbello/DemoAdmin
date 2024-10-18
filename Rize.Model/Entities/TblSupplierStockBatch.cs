using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierStockBatch
{
    public Guid Rowguid { get; set; }

    public int? SupSupplierId { get; set; }

    public string? XmlRequestStock { get; set; }

    public string? XmlResponseStock { get; set; }

    public string? ExceptionType { get; set; }

    public string? ExceptionMessage { get; set; }

    public string? RequestedBy { get; set; }

    public DateTime DateCreated { get; set; }

    public virtual TblSupplier? SupSupplier { get; set; }
}
