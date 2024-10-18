using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationCategoryElementBySupplier
{
    public int DeliveryEstimationCategoryElementBySupplierId { get; set; }

    public int DeliveryEstimationCategoryElementId { get; set; }

    public int SupplierId { get; set; }

    public short NumberofHours { get; set; }

    public bool Status { get; set; }

    public DateTime InsertDate { get; set; }

    public virtual DeliveryEstimationCategoryElement DeliveryEstimationCategoryElement { get; set; } = null!;

    public virtual TblSupplier Supplier { get; set; } = null!;
}
