using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblPaymentStatus
{
    public int PayStaPaymentStatusId { get; set; }

    public string? PayStaDescription { get; set; }

    public int? PayStaDisplaySequence { get; set; }

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
