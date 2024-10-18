using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCompanyEmployeeUserGroup
{
    public int ComEmpUseGroCompanyEmployeeUserGroupId { get; set; }

    public string? ComEmpUseGroDescription { get; set; }

    public int? ComEmpUseGroAuthorizationLevel { get; set; }

    public virtual ICollection<TblCompanyEmployee> TblCompanyEmployees { get; set; } = new List<TblCompanyEmployee>();
}
