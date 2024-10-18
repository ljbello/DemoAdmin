using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoOrderProcessHistory
{
    public Guid AutoOrderProcessHistoryId { get; set; }

    public int OrdOrderId { get; set; }

    public DateTime DateTimeCompleted { get; set; }

    public bool Result { get; set; }
}
