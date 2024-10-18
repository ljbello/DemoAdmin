using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminUserRole
{
    public int UserRoleId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual AdminRole Role { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
