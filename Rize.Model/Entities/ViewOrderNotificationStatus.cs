using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewOrderNotificationStatus
{
    public int OrderNotificationId { get; set; }

    public string? Status { get; set; }

    public DateTime? ScheduledTime { get; set; }
}
