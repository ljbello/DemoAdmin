using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class RptOrderPaymentIssue
{
    public long IssueId { get; set; }

    public long? OrderId { get; set; }

    public DateOnly? Createdate { get; set; }
}
