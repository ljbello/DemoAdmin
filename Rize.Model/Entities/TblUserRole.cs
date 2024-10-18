using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblUserRole
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public virtual TblRole Role { get; set; } = null!;
}
