using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationSupplierClosure
{
    public int DeliveryEstimationSupplierClosureId { get; set; }

    public int SupplierId { get; set; }

    public string? Note { get; set; }

    public DateOnly ClosureDate { get; set; }

    public bool? Status { get; set; }

    public DateTime InsertDate { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
