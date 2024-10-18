using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSampleCardStockOrderLineItem
{
    public int SampleCardStockOrderId { get; set; }

    public int ProductId { get; set; }

    public string SupplierProductNumber { get; set; } = null!;

    public int Quantity { get; set; }

    public string? InternalNotes { get; set; }

    public virtual TblSampleCardStockOrder SampleCardStockOrder { get; set; } = null!;
}
