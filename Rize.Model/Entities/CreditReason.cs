using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CreditReason
{
    public int CreditReasonId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CreditReasonDetail> CreditReasonDetails { get; set; } = new List<CreditReasonDetail>();
}
