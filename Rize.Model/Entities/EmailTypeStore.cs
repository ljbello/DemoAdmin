using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailTypeStore
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int EmailTypeId { get; set; }

    public int TemplateId { get; set; }

    public string? EmailBody { get; set; }

    public string? EmailHeading { get; set; }

    public string? EmailSubHeading { get; set; }

    public string? Subject { get; set; }

    public string? Sender { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public string? ReplyTo { get; set; }

    public string? Bcc { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual EmailType EmailType { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store Store { get; set; } = null!;

    public virtual EmailTemplate Template { get; set; } = null!;
}
