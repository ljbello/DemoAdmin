using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductUse
{
    public int ProductUseId { get; set; }

    public string ProductUse1 { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }
}
