using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminTreeNodeRole
{
    public int TreeNodeRoleId { get; set; }

    public int RoleId { get; set; }

    public int TreeNodeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual AdminRole Role { get; set; } = null!;

    public virtual AdminTreeNode TreeNode { get; set; } = null!;
}
