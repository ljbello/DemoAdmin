using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AopworkTableDebug
{
    public int Id { get; set; }

    public int OrdOrderId { get; set; }

    public string? RemovalReason { get; set; }

    public string? ReInsertReason { get; set; }

    public DateTime RemovalTime { get; set; }
}
