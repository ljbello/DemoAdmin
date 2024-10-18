using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerAccountCredit
{
    public int CustomerAccountCreditId { get; set; }

    public Guid CustomerAccountId { get; set; }

    public string Name { get; set; } = null!;

    public decimal OriginalAmount { get; set; }

    public decimal CurrentAmount { get; set; }

    public int DurationInDays { get; set; }

    public int? CategoryId { get; set; }

    public int? ProductTypeId { get; set; }

    public string? Reason { get; set; }

    public string? ReasonDetail { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int? OrderId { get; set; }

    public bool? IsAllowOffsetShipping { get; set; }

    public virtual CustomerAccount CustomerAccount { get; set; } = null!;

    public virtual ICollection<OrderCredit> OrderCredits { get; set; } = new List<OrderCredit>();

    public virtual ICollection<OrderLineCredit> OrderLineCredits { get; set; } = new List<OrderLineCredit>();
}
