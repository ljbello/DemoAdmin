using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminStoreRoleTemplate
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? StoreId { get; set; }

    public virtual AdminRole? Role { get; set; }

    public virtual Store? Store { get; set; }
}
