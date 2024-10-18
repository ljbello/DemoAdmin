using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblUserDepartment
{
    public int DepartmentId { get; set; }

    public string? Description { get; set; }

    public Guid Rowguid { get; set; }

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
