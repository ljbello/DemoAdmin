using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreSupplier
{
    public int Id { get; set; }

    public int StoStoreId { get; set; }

    public int SupSupplierId { get; set; }

    public string? StoSupAccountNumber { get; set; }

    public bool? WhetherGetInventory { get; set; }

    public virtual Store StoStore { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;
}
