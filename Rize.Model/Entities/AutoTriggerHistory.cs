using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoTriggerHistory
{
    public int Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? AutoTriggerId { get; set; }

    public int? OrderId { get; set; }

    public virtual AutoTrigger? AutoTrigger { get; set; }
}
