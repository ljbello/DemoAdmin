using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminPanelLock
{
    public Guid Id { get; set; }

    public int PanelId { get; set; }

    public string LockKey { get; set; } = null!;

    public DateTime LockedOn { get; set; }

    public int LockedBy { get; set; }

    public virtual TblUser LockedByNavigation { get; set; } = null!;

    public virtual AdminPanel Panel { get; set; } = null!;
}
