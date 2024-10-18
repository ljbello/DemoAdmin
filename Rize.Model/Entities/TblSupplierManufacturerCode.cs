using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierManufacturerCode
{
    public int SupSupplierId { get; set; }

    public string SupManCodManufacturerCode { get; set; } = null!;

    public int ManManufacturerId { get; set; }

    public virtual TblManufacturer ManManufacturer { get; set; } = null!;
}
