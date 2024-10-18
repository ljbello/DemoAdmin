using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderPaymentAction
{
    public int OrderPaymentActionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
