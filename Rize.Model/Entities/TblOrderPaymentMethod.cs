using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderPaymentMethod
{
    public int OrdPayMetOrderPaymentMethodId { get; set; }

    public string OrdPayMetDescription { get; set; } = null!;

    public int OrdPayMetSequence { get; set; }

    public virtual ICollection<StorePayment> StorePayments { get; set; } = new List<StorePayment>();

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
