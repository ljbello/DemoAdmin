using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCreditCardType
{
    public int CreCarTypCreditCardTypeId { get; set; }

    public string CreCarTypDescription { get; set; } = null!;

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
