using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminPanel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public bool RequiresLock { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<AdminPagePanel> AdminPagePanels { get; set; } = new List<AdminPagePanel>();

    public virtual ICollection<AdminPanelLock> AdminPanelLocks { get; set; } = new List<AdminPanelLock>();

    public virtual ICollection<AdminPanelRoleTemplate> AdminPanelRoleTemplates { get; set; } = new List<AdminPanelRoleTemplate>();

    public virtual ICollection<AdminPanelUserPermission> AdminPanelUserPermissions { get; set; } = new List<AdminPanelUserPermission>();
}
