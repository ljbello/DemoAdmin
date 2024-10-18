using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductStatus
{
    public int ProStaProductStatusId { get; set; }

    public string ProStaDescription { get; set; } = null!;

    public bool ProStaDisplay { get; set; }

    public string? ProStaFriendlyDescription { get; set; }

    public string? ProStaFriendlyName { get; set; }

    public virtual ICollection<TblStoreProduct> TblStoreProducts { get; set; } = new List<TblStoreProduct>();
}
