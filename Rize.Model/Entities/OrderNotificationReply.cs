using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderNotificationReply
{
    public int Id { get; set; }

    public int OrderNotificationId { get; set; }

    public int CreatedBy { get; set; }

    public string Message { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual OrderNotification OrderNotification { get; set; } = null!;
}
