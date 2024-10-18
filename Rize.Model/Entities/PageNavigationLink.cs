using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageNavigationLink
{
    public Guid Id { get; set; }

    public int DepartmentId { get; set; }

    public string Text { get; set; } = null!;

    public string Link { get; set; } = null!;

    public int Sequence { get; set; }

    public bool More { get; set; }

    public bool Active { get; set; }

    public bool Visible { get; set; }
}
