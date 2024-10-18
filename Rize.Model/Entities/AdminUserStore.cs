using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminUserStore
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int UserId { get; set; }

    public virtual Store Store { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
