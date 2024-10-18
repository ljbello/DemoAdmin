using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblFrontOption
{
    public int FroOptFrontOptionId { get; set; }

    public string FroOptFrontOptionCode { get; set; } = null!;

    public string? FroOptText { get; set; }

    public virtual ICollection<TblFrontOptionGroup> FroOptGroFrontOptionGroups { get; set; } = new List<TblFrontOptionGroup>();
}
