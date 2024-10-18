using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PlateCreationHistory
{
    public Guid PlateCreationHistoryId { get; set; }

    public int OrderLineId { get; set; }

    public string InstanceId { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime? CompletedOn { get; set; }
}
