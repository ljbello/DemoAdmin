using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailLog
{
    public Guid EmailLogId { get; set; }

    public int? StoreId { get; set; }

    public int? OrderId { get; set; }

    public int? OrderlineId { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public string ToEmailAddress { get; set; } = null!;

    public int EmailTypeId { get; set; }

    public string? RequestId { get; set; }

    public DateTime? QueuedDate { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public bool? IsSuccessful { get; set; }

    public bool? ShouldRetry { get; set; }

    public int? SendAttempts { get; set; }

    public int? SavedProjectId { get; set; }

    public int? ReviewEntryId { get; set; }

    public string? Message { get; set; }

    public string? LastErrorMessage { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public bool Ignore { get; set; }

    public Guid? EmailSubscriptionId { get; set; }

    public bool Delivered { get; set; }

    public bool Bounced { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual EmailType EmailType { get; set; } = null!;

    public virtual Store? Store { get; set; }
}
