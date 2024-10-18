using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class FaqItem
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public bool Active { get; set; }

    public int CategoryId { get; set; }

    public int Ordinal { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual FaqCategory Category { get; set; } = null!;

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store Store { get; set; } = null!;
}
