using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductionType
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public int ProductionTypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }
}
