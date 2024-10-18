using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CouponTrackerOrder
{
    public long CouponTrackerOrderId { get; set; }

    public long CouponTrackerId { get; set; }

    public long OrderId { get; set; }

    public bool EmailSent { get; set; }

    public DateTime InsertDate { get; set; }
}
