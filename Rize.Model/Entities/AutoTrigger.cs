using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoTrigger
{
    public int Id { get; set; }

    public string? RuleName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int? StoreId { get; set; }

    public DateTime? LastRun { get; set; }

    public string? SqlQuery { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AutoTriggerAction> AutoTriggerActions { get; set; } = new List<AutoTriggerAction>();

    public virtual ICollection<AutoTriggerHistory> AutoTriggerHistories { get; set; } = new List<AutoTriggerHistory>();

    public virtual ICollection<AutoTriggerRule> AutoTriggerRules { get; set; } = new List<AutoTriggerRule>();

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store? Store { get; set; }
}
