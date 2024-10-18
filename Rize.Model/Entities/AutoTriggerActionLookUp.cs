using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoTriggerActionLookUp
{
    public int Id { get; set; }

    public string? ActionName { get; set; }

    public string? SubActionName { get; set; }

    public string? ProcessProcedure { get; set; }

    public string? KeyValueQuery { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AutoTriggerAction> AutoTriggerActions { get; set; } = new List<AutoTriggerAction>();
}
