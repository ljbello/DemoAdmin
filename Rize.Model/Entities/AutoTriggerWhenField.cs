using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoTriggerWhenField
{
    public int Id { get; set; }

    public string? DisplayName { get; set; }

    public string? TableName { get; set; }

    public string? FieldName { get; set; }

    public string? JoinQuery { get; set; }

    public string? KeyValueQuery { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AutoTriggerRule> AutoTriggerRules { get; set; } = new List<AutoTriggerRule>();
}
