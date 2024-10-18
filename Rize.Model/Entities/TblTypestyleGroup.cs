using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblTypestyleGroup
{
    public int TypGroTypestyleGroupId { get; set; }

    public string? TypGroDescription { get; set; }

    public int TypGroTypestyleGroupYear { get; set; }

    public virtual ICollection<TblTypestyle> TypTypestyles { get; set; } = new List<TblTypestyle>();
}
