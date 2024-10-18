using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminTreeNodeUserPermission
{
    public int TreeNodeId { get; set; }

    public int UserId { get; set; }

    public bool? Show { get; set; }

    public virtual AdminTreeNode TreeNode { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
