using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAlternateEnvelope
{
    public int SupEnvSupplierEnvelopeId { get; set; }

    public int AltEnvAlternateSupplierEnvelopeId { get; set; }

    public string? AltEnvNotes { get; set; }

    public bool AltEnvDeleted { get; set; }
}
