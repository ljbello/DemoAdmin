using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblManufacturer
{
    public int ManManufacturerId { get; set; }

    public string ManName { get; set; } = null!;

    public string? ManUrl { get; set; }

    public string ManAbbreviation { get; set; } = null!;

    public virtual ICollection<TblLayout> TblLayouts { get; set; } = new List<TblLayout>();

    public virtual ICollection<TblProduct> TblProducts { get; set; } = new List<TblProduct>();

    public virtual ICollection<TblSupplierEnvelope> TblSupplierEnvelopes { get; set; } = new List<TblSupplierEnvelope>();
}
