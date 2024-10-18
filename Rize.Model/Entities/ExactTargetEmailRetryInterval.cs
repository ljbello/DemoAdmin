using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ExactTargetEmailRetryInterval
{
    public int EmailRetryId { get; set; }

    public int PreviousAttemptCount { get; set; }

    public int Hours { get; set; }

    public int Minutes { get; set; }

    public int Seconds { get; set; }
}
