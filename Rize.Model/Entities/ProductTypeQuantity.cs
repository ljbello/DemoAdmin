using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductTypeQuantity
{
    public int ProductTypeId { get; set; }

    public int StoreId { get; set; }

    public int Quantity { get; set; }

    public int VariationId { get; set; }

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
