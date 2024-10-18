using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblRole
{
    public int RoleId { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<TblUserRole> TblUserRoles { get; set; } = new List<TblUserRole>();
}
