using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminPage
{
    public int PageId { get; set; }

    public string DisplayName { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<AdminPagePanel> AdminPagePanels { get; set; } = new List<AdminPagePanel>();

    public virtual ICollection<AdminTreeNode> AdminTreeNodes { get; set; } = new List<AdminTreeNode>();
}
