using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PaperFinish
{
    public int PaperFinishId { get; set; }

    public string Name { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? SupplierCardFrontFinish { get; set; }

    public virtual ICollection<SupplierPaperFinishMapping> SupplierPaperFinishMappings { get; set; } = new List<SupplierPaperFinishMapping>();
}
