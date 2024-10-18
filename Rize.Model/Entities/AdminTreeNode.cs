using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminTreeNode
{
    public int TreeNodeId { get; set; }

    public int NodeOrder { get; set; }

    public int NodeLevel { get; set; }

    public string DisplayName { get; set; } = null!;

    public int? PageId { get; set; }

    public int? ParentTreeNodeId { get; set; }

    public string NodeIconId { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public bool? ShowDataCount { get; set; }

    public int? MenuType { get; set; }

    public string? ExternalUrl { get; set; }

    public string? ScriptCode { get; set; }

    public virtual ICollection<AdminPanelRoleTemplate> AdminPanelRoleTemplates { get; set; } = new List<AdminPanelRoleTemplate>();

    public virtual ICollection<AdminPanelUserPermission> AdminPanelUserPermissions { get; set; } = new List<AdminPanelUserPermission>();

    public virtual ICollection<AdminTreeNodeRole> AdminTreeNodeRoles { get; set; } = new List<AdminTreeNodeRole>();

    public virtual ICollection<AdminTreeNodeUserPermission> AdminTreeNodeUserPermissions { get; set; } = new List<AdminTreeNodeUserPermission>();

    public virtual AdminPage? Page { get; set; }
}
