using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLineCredit
{
    public int OrderLineCreditId { get; set; }

    public int OrderLineId { get; set; }

    public int CustomerAccountCreditId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual CustomerAccountCredit CustomerAccountCredit { get; set; } = null!;

    public virtual TblOrderLine OrderLine { get; set; } = null!;
}
