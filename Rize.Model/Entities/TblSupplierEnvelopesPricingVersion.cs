using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierEnvelopesPricingVersion
{
    public int SupplierEnvelopeId { get; set; }

    public string? DpproductOptionPriceGroupId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int StoreId { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store Store { get; set; } = null!;
}
