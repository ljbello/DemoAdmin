using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Layout
{
    public int LayoutId { get; set; }

    public int? LayoutIconId { get; set; }

    public DateTime EntityCreated { get; set; }

    public string? Name { get; set; }

    public string? ProductOptionKeyId { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<EnvelopeAddressingStyle> EnvelopeAddressingStyles { get; set; } = new List<EnvelopeAddressingStyle>();

    public virtual LayoutIcon? LayoutIcon { get; set; }

    public virtual ICollection<MasterLayout> MasterLayouts { get; set; } = new List<MasterLayout>();

    public virtual ICollection<ProductVariationSectionLayout> ProductVariationSectionLayouts { get; set; } = new List<ProductVariationSectionLayout>();

    public virtual ICollection<SupplierEnvelopeSectionLayout> SupplierEnvelopeSectionLayouts { get; set; } = new List<SupplierEnvelopeSectionLayout>();
}
