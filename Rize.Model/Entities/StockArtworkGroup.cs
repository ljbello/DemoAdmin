using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StockArtworkGroup
{
    public int Id { get; set; }

    public string GroupName { get; set; } = null!;

    public DateOnly CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<StockArtworkGroupItem> StockArtworkGroupItems { get; set; } = new List<StockArtworkGroupItem>();
}
