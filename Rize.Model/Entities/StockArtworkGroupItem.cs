using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StockArtworkGroupItem
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string StockArtworkFilePath { get; set; } = null!;

    public string? Name { get; set; }

    public int SortIndex { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual StockArtworkGroup Group { get; set; } = null!;
}
