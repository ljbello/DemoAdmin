using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetEnvelopePersonalization
{
    public int OrderLineId { get; set; }

    public int EnvelopeId { get; set; }

    public int SupplierEnvelopeId { get; set; }
}
