using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PlateCreationStatus
{
    public Guid PlateCreationStatusId { get; set; }

    public int OrderLineId { get; set; }

    public string InstanceId { get; set; } = null!;

    public DateTime StartTime { get; set; }
}
