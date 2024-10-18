using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierEnvelopeSection
{
    public int SupplierEnvelopeId { get; set; }

    public int SectionId { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int PlateRotation { get; set; }

    public int PlateAnchor { get; set; }

    public string PreviewGroup { get; set; } = null!;

    public bool? Locked { get; set; }

    public DateTime EntityCreated { get; set; }

    public virtual TblSupplierEnvelope SupplierEnvelope { get; set; } = null!;
}
