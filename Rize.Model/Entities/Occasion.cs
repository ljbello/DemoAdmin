using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Occasion
{
    public int OccasionId { get; set; }

    public string OccasionName { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual ICollection<ProductOccasion> ProductOccasions { get; set; } = new List<ProductOccasion>();
}
