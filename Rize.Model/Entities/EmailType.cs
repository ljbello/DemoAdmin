using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailType
{
    public int EmailTypeId { get; set; }

    public string Title { get; set; } = null!;

    public int Priority { get; set; }

    public string TriggerSendKey { get; set; } = null!;

    public string EmailLookUpId { get; set; } = null!;

    public int SendType { get; set; }

    public bool State { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public bool AllowUnsubscribe { get; set; }

    public int? QueueCapHours { get; set; }

    public int? QueueCap { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<EmailLog> EmailLogs { get; set; } = new List<EmailLog>();

    public virtual ICollection<EmailSentQueue> EmailSentQueues { get; set; } = new List<EmailSentQueue>();

    public virtual ICollection<EmailTypeStore> EmailTypeStores { get; set; } = new List<EmailTypeStore>();
}
