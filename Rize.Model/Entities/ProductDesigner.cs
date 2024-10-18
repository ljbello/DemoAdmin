using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductDesigner
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool Active { get; set; }
}
