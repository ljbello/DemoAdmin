using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreProductType
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ProductTypeId { get; set; }

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
