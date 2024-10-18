using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderNotificationUser
{
    public int OrderNotificationUserId { get; set; }

    public int OrderNotificationId { get; set; }

    public int ToUserId { get; set; }

    public bool IsDismiss { get; set; }

    public DateTime ScheduledTime { get; set; }

    public virtual OrderNotification OrderNotification { get; set; } = null!;

    public virtual TblUser ToUser { get; set; } = null!;
}
