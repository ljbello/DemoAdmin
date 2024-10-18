using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductionTime
{
    public int ProTimProductionTimeId { get; set; }

    public string ProTimDescription { get; set; } = null!;

    public byte ProTimDisplayOrder { get; set; }

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();

    public virtual ICollection<TblProduct> TblProducts { get; set; } = new List<TblProduct>();
}
