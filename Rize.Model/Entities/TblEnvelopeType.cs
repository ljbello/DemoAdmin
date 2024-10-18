using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblEnvelopeType
{
    public string EnvTypEnvelopeTypeId { get; set; } = null!;

    public string EnvTypDescription { get; set; } = null!;

    public decimal EnvTypAdditionalCostPer25 { get; set; }

    public int EnvTypDisplayOrder { get; set; }

    public int EnvTypDefaultRanking { get; set; }

    public virtual ICollection<Envelope> Envelopes { get; set; } = new List<Envelope>();
}
