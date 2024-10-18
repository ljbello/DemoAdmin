using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCompanyDepartment
{
    public int ComDepCompanyDepartmentId { get; set; }

    public string? ComDepDescription { get; set; }

    public virtual ICollection<TblCompanyEmployee> TblCompanyEmployees { get; set; } = new List<TblCompanyEmployee>();
}
