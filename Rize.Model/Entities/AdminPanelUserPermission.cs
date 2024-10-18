using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminPanelUserPermission
{
    public int Id { get; set; }

    public int PanelId { get; set; }

    public int UserId { get; set; }

    public bool? View { get; set; }

    public bool? Edit { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? CreatdedBy { get; set; }

    public int? TreeNodeId { get; set; }

    public virtual AdminPanel Panel { get; set; } = null!;

    public virtual AdminTreeNode? TreeNode { get; set; }

    public virtual TblUser User { get; set; } = null!;
}
