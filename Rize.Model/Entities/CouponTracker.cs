using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CouponTracker
{
    public int CouponTrackerId { get; set; }

    public string CouponCode { get; set; } = null!;

    public bool Isactive { get; set; }
}
