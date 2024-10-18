using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblLayout
{
    public int LayLayoutId { get; set; }

    public int LayTypLayoutTypeId { get; set; }

    public int SupSupplierId { get; set; }

    public int ManManufacturerId { get; set; }

    public string LayManufacturerItemNumber { get; set; } = null!;

    public int LayWidth { get; set; }

    public int LayHeight { get; set; }

    public int LayPriority { get; set; }

    public virtual TblLayoutType LayTypLayoutType { get; set; } = null!;

    public virtual TblManufacturer ManManufacturer { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<TblLayoutArea> TblLayoutAreas { get; set; } = new List<TblLayoutArea>();
}
