using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOccasion
{
    public int ProductOccasionId { get; set; }

    public int ProductId { get; set; }

    public int OccasionId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public virtual Occasion Occasion { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}
