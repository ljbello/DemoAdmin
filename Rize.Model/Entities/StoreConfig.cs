using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreConfig
{
    public int StoreId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public virtual Store Store { get; set; } = null!;
}
