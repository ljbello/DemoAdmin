using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class LayoutIcon
{
    public int LayoutIconId { get; set; }

    public string ImageName { get; set; } = null!;

    public string? LayoutName { get; set; }

    public int? SortId { get; set; }

    public DateTime EntityCreated { get; set; }

    public virtual ICollection<Layout> Layouts { get; set; } = new List<Layout>();
}
