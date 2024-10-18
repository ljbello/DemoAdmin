using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminRole
{
    public int RoleId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<AdminPanelRoleTemplate> AdminPanelRoleTemplates { get; set; } = new List<AdminPanelRoleTemplate>();

    public virtual ICollection<AdminStoreRoleTemplate> AdminStoreRoleTemplates { get; set; } = new List<AdminStoreRoleTemplate>();

    public virtual ICollection<AdminTreeNodeRole> AdminTreeNodeRoles { get; set; } = new List<AdminTreeNodeRole>();

    public virtual ICollection<AdminUserRole> AdminUserRoles { get; set; } = new List<AdminUserRole>();
}
