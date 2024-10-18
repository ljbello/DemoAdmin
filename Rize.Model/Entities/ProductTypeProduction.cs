using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductTypeProduction
{
    public int Id { get; set; }

    public int ProductTypeId { get; set; }

    public int ProductionTypeId { get; set; }

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual ProductionType ProductionType { get; set; } = null!;
}
