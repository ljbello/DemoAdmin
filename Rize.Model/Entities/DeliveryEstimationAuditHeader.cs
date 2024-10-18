using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DeliveryEstimationAuditHeader
{
    public long DeliveryEstimationAuditHeaderId { get; set; }

    public long? SessionId { get; set; }

    public long? OrderLineId { get; set; }

    public long SupplierId { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public DateTime? EstimatedSubmitDate { get; set; }

    public short? UpsbusinessDaysInTransit { get; set; }
}
