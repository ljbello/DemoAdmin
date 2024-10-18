using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CreditReasonDetail
{
    public int CreditReasonDetailId { get; set; }

    public int CreditReasonId { get; set; }

    public string? Group { get; set; }

    public string? Description { get; set; }

    public virtual CreditReason CreditReason { get; set; } = null!;
}
