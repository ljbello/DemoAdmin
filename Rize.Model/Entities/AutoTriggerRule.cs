using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoTriggerRule
{
    public int Id { get; set; }

    public int? AutoTriggerId { get; set; }

    public int? Ordinal { get; set; }

    public string? Operator { get; set; }

    public int? WhenFieldId { get; set; }

    public string? WhenCondition { get; set; }

    public string? WhenValue { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual AutoTrigger? AutoTrigger { get; set; }

    public virtual AutoTriggerWhenField? WhenField { get; set; }
}
