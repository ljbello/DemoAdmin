using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderCredit
{
    public int OrderCreditId { get; set; }

    public int OrderId { get; set; }

    public int CustomerAccountCreditId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual CustomerAccountCredit CustomerAccountCredit { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
