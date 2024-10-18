using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderNotification
{
    public int OrderNotificationId { get; set; }

    public int CreatedBy { get; set; }

    public string Message { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int? OrderId { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual Order? Order { get; set; }

    public virtual ICollection<OrderNotificationReply> OrderNotificationReplies { get; set; } = new List<OrderNotificationReply>();

    public virtual ICollection<OrderNotificationUser> OrderNotificationUsers { get; set; } = new List<OrderNotificationUser>();
}
