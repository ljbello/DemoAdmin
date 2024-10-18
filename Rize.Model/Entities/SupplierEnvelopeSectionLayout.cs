using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierEnvelopeSectionLayout
{
    public int SupplierEnvelopeId { get; set; }

    public int SectionId { get; set; }

    public int LayoutId { get; set; }

    public DateTime EntityCreated { get; set; }

    public int ClipX { get; set; }

    public int ClipY { get; set; }

    public int ClipWidth { get; set; }

    public int ClipHeight { get; set; }

    public virtual Layout Layout { get; set; } = null!;

    public virtual Section Section { get; set; } = null!;
}
