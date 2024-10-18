using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class FontGroup
{
    public int FontGroupId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TblTypestyle> TblTypestyles { get; set; } = new List<TblTypestyle>();
}
