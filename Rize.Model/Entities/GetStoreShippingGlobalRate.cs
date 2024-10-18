using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetStoreShippingGlobalRate
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ShippingMethodId { get; set; }

    public string ShippingMethodDescription { get; set; } = null!;

    public string StoreName { get; set; } = null!;
}
