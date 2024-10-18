using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationCategoryElement
{
    public int DeliveryEstimationCategoryElementId { get; set; }

    public int DeliveryEstimationCategoryId { get; set; }

    public string DeliveryEstimationCategoryElement1 { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime InsertDate { get; set; }

    public string? DisplayName { get; set; }

    public virtual DeliveryEstimationCategory DeliveryEstimationCategory { get; set; } = null!;

    public virtual ICollection<DeliveryEstimationCategoryElementBySupplier> DeliveryEstimationCategoryElementBySuppliers { get; set; } = new List<DeliveryEstimationCategoryElementBySupplier>();
}
