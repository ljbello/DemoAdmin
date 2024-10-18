using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSuggestedWording
{
    public int SugWorSuggestedWordingId { get; set; }

    public int LayAreTypLayoutAreaTypeId { get; set; }

    public string SugWorOrientation { get; set; } = null!;

    public string? SugWorXml { get; set; }

    public virtual TblLayoutAreaType LayAreTypLayoutAreaType { get; set; } = null!;

    public virtual ICollection<TblOccasion> OccOccasions { get; set; } = new List<TblOccasion>();
}
