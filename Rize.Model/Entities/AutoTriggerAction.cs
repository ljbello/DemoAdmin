using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoTriggerAction
{
    public int Id { get; set; }

    public int? AutoTriggerId { get; set; }

    public int? Ordinal { get; set; }

    public string? ActionValue { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public DateOnly? ModifiedOn { get; set; }

    public int? ActionId { get; set; }

    public virtual AutoTriggerActionLookUp? Action { get; set; }

    public virtual AutoTrigger? AutoTrigger { get; set; }
}
