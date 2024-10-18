using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminPanelRoleTemplate
{
    public int Id { get; set; }

    public int? PanelId { get; set; }

    public int? RoleId { get; set; }

    public bool? View { get; set; }

    public bool? Edit { get; set; }

    public int? TreeNodeId { get; set; }

    public virtual AdminPanel? Panel { get; set; }

    public virtual AdminRole? Role { get; set; }

    public virtual AdminTreeNode? TreeNode { get; set; }
}
