using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreFont
{
    public int Id { get; set; }

    public int FontId { get; set; }

    public int StoreId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual TblTypestyle Font { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
