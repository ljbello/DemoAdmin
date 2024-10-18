using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblFrontOptionGroup
{
    public int FroOptGroFrontOptionGroupId { get; set; }

    public string FroOptGroDescription { get; set; } = null!;

    public int FroOptGroGroupYear { get; set; }

    public virtual ICollection<TblFrontOption> FroOptFrontOptions { get; set; } = new List<TblFrontOption>();
}
