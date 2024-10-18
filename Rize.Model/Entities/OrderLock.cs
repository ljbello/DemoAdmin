using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLock
{
    public int OrderId { get; set; }

    public DateTime LockDate { get; set; }

    public int UserId { get; set; }

    public DateTime? LastRefresh { get; set; }
}
