using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationEnvelope
{
    public int ProductVariationId { get; set; }

    public int SupplierEnvelopeId { get; set; }
}
