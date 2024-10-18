using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierHandlingCharge
{
    public int SupplierHandlingChargeId { get; set; }

    public int SupplierId { get; set; }

    public decimal AmountCharged { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string? Comments { get; set; }
}
