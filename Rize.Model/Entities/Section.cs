using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Section
{
    public int SectionId { get; set; }

    public string Name { get; set; } = null!;

    public string? Side { get; set; }

    public int EntityRank { get; set; }

    public DateTime EntityCreated { get; set; }

    public virtual ICollection<ProductVariationSection> ProductVariationSections { get; set; } = new List<ProductVariationSection>();

    public virtual ICollection<SupplierEnvelopeSectionLayout> SupplierEnvelopeSectionLayouts { get; set; } = new List<SupplierEnvelopeSectionLayout>();
}
