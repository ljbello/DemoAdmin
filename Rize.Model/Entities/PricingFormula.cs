using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PricingFormula
{
    public int Id { get; set; }

    public string KeyCode { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal SetupCharge { get; set; }

    public decimal UnitPrice { get; set; }

    public int StoreId { get; set; }

    public decimal Rounding { get; set; }

    public int Sort { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }
}
