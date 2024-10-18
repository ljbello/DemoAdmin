using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAuthorizationResponseCode
{
    public int AutResCodResponseCode { get; set; }

    public string AutResCodDescription { get; set; } = null!;

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
