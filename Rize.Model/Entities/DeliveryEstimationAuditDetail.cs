using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationAuditDetail
{
    public long DeliveryEstimationAuditDetailId { get; set; }

    public long DeliveryEstimationAuditHeaderId { get; set; }

    public int DeliveryEstimationCategoryId { get; set; }

    public string DeliveryEstimationCategory { get; set; } = null!;

    public int DeliveryEstimationCategoryElementId { get; set; }

    public string DeliveryEstimationCategoryElement { get; set; } = null!;

    public int NumberofHours { get; set; }

    public DateTime InsertDate { get; set; }
}
