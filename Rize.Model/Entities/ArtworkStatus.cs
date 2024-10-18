using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ArtworkStatus
{
    public int Id { get; set; }

    public string DisplayName { get; set; } = null!;

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}
