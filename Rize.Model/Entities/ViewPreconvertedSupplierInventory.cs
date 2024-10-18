using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewPreconvertedSupplierInventory
{
    public string? ProSupplierProductNumber { get; set; }

    public int? SupSupplierId { get; set; }

    public string SupName { get; set; } = null!;

    public string? SupProStockNumber { get; set; }

    public int InventoryOnHand { get; set; }

    public int InventoryOnOrder { get; set; }

    public int InventoryCommitted { get; set; }

    public int? TotalInventory { get; set; }

    public DateTime? LastUpdated { get; set; }
}
