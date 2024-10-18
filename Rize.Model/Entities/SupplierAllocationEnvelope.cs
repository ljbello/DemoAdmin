using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationEnvelope
{
    public int SupplierAllocationEnvelopeId { get; set; }

    public int SupplierId { get; set; }

    public int SupplierEnvelopeId { get; set; }
}
