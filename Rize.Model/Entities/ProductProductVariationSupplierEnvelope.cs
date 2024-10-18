using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductProductVariationSupplierEnvelope
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public int SupplierEnvelopeId { get; set; }

    public int StoreId { get; set; }

    public bool IsDefault { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ProductVariation ProductVariation { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual TblSupplierEnvelope SupplierEnvelope { get; set; } = null!;
}
