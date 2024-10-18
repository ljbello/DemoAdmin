using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StockArtworkTree
{
    public int StockArtworkTreeId { get; set; }

    public string? Name { get; set; }

    public int? ParentId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<StockArtwork> StockArtworks { get; set; } = new List<StockArtwork>();
}
