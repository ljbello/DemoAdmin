using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Content { get; set; }

    public int StoreId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<EmailTypeStore> EmailTypeStores { get; set; } = new List<EmailTypeStore>();

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store Store { get; set; } = null!;
}
