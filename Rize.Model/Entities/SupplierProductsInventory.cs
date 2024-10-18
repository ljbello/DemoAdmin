using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductsInventory
{
    public int Id { get; set; }

    public string SupplierProductSku { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public int? QuantityOnHand { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }
}
