using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductionType
{
    public int ProductionTypeId { get; set; }

    public string ProductionType1 { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public bool? AllowAop { get; set; }

    public virtual ICollection<InkColorGroup> InkColorGroups { get; set; } = new List<InkColorGroup>();

    public virtual ICollection<ProductTypeProduction> ProductTypeProductions { get; set; } = new List<ProductTypeProduction>();
}
