using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAuthorizationResponseReasonCode
{
    public int AutResReaCodResponseReasonCode { get; set; }

    public int? AutResCodResponseCode { get; set; }

    public string? AutResReaCodDescription { get; set; }

    public string? AutResReaCodNotes { get; set; }

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
