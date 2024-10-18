using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblLayoutType
{
    public int LayTypLayoutTypeId { get; set; }

    public string LayTypTypeName { get; set; } = null!;

    public virtual ICollection<TblLayout> TblLayouts { get; set; } = new List<TblLayout>();
}
