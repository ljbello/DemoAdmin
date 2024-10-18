using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductsToBeImported
{
    public long Id { get; set; }

    public long SupSupplierId { get; set; }

    public string ProProductNumber { get; set; } = null!;

    public DateTime? DateImported { get; set; }

    public int StoStoreId { get; set; }
}
