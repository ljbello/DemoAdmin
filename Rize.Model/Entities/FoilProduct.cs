using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class FoilProduct
{
    public int ProductId { get; set; }

    public string Spc { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}
