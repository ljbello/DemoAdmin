using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VProductAlternateEnvelope
{
    public int ProProductId { get; set; }

    public int SupEnvSupplierEnvelopeId { get; set; }

    public int AltEnvAlternateSupplierEnvelopeId { get; set; }

    public string? AltEnvNotes { get; set; }
}
