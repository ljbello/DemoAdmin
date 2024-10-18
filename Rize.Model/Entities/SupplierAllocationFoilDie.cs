using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationFoilDie
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public string FoilDieCode { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
