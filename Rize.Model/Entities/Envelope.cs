using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Envelope
{
    public int EnvEnvelopeId { get; set; }

    public string Name { get; set; } = null!;

    public string? EnvTypEnvelopeTypeId { get; set; }

    public string? Description { get; set; }

    public virtual TblEnvelopeType? EnvTypEnvelopeType { get; set; }

    public virtual ICollection<TblChristmasCard> TblChristmasCards { get; set; } = new List<TblChristmasCard>();

    public virtual ICollection<TblSupplierEnvelope> TblSupplierEnvelopes { get; set; } = new List<TblSupplierEnvelope>();
}
