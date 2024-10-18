using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationCategory
{
    public int DeliveryEstimationCategoryId { get; set; }

    public string DeliveryEstimationCategory1 { get; set; } = null!;

    public bool Cumulative { get; set; }

    public bool Status { get; set; }

    public DateTime InsertDate { get; set; }

    public virtual ICollection<DeliveryEstimationCategoryElement> DeliveryEstimationCategoryElements { get; set; } = new List<DeliveryEstimationCategoryElement>();
}
