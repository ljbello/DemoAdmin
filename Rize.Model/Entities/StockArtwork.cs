using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StockArtwork
{
    public int Id { get; set; }

    public string? StockArtworkFileName { get; set; }

    public string? Filepath { get; set; }

    public string? Keywords { get; set; }

    public int? StockArtworkTreeId { get; set; }

    public short? Type { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual StockArtworkTree? StockArtworkTree { get; set; }
}
