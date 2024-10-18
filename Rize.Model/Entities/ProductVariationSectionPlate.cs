using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationSectionPlate
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int VariationId { get; set; }

    public int SectionId { get; set; }

    public string FileName { get; set; } = null!;

    public string? Color { get; set; }

    public bool Active { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
