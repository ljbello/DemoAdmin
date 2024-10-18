using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAuthorizationEcheckType
{
    public string AutEchTypAuthorizationEcheckTypeId { get; set; } = null!;

    public string AutEchTypDescription { get; set; } = null!;

    public int AutEchTypSequence { get; set; }

    public string AutEchTypNotes { get; set; } = null!;

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
