using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class NavDestinationType
{
    public int NavDestinationTypeId { get; set; }

    public string DestinationTypeName { get; set; } = null!;

    public virtual ICollection<TblStoreDepartment> TblStoreDepartments { get; set; } = new List<TblStoreDepartment>();
}
