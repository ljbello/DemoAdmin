using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreShippingMethod
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ShippingMethodId { get; set; }

    public virtual TblShippingMethod ShippingMethod { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
