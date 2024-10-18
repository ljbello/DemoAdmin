using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationSupplierOrderCutOff
{
    public int DeliveryEstimationSupplierOrderCutOffId { get; set; }

    public int SupplierId { get; set; }

    public TimeOnly CutOffTime { get; set; }

    public DateTime InsertDate { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
