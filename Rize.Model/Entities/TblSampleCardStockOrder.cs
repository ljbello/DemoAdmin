using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSampleCardStockOrder
{
    public int SampleCardStockOrderId { get; set; }

    public int SupplierId { get; set; }

    public DateTime? OrderDate { get; set; }

    public bool OrderSentViaEmail { get; set; }

    public string? EmailException { get; set; }

    public virtual ICollection<TblSampleCardStockOrderLineItem> TblSampleCardStockOrderLineItems { get; set; } = new List<TblSampleCardStockOrderLineItem>();
}
