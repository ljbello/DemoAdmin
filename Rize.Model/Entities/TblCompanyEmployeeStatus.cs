using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCompanyEmployeeStatus
{
    public int ComEmpStaCompanyEmployeeStatusId { get; set; }

    public string? ComEmpStaDescription { get; set; }

    public virtual ICollection<TblCompanyEmployee> TblCompanyEmployees { get; set; } = new List<TblCompanyEmployee>();
}
