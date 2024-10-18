using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CategoryTotal
{
    public int DepartmentId { get; set; }

    public int TotalProducts { get; set; }

    public string CategoryUrl { get; set; } = null!;

    public DateTime DateUpdated { get; set; }
}
