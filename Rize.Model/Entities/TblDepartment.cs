using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblDepartment
{
    public int DepDepartmentId { get; set; }

    public int? DepParentDepartmentId { get; set; }

    public string DepName { get; set; } = null!;

    public int DepLevel { get; set; }

    public int DepRank { get; set; }

    public int DepHierarchicalSort { get; set; }

    public int DepChildCount { get; set; }

    public int DepShowInTopMenu { get; set; }

    public int? DepDefaultVerseGroup { get; set; }

    public virtual ICollection<AssortmentPack> AssortmentPacks { get; set; } = new List<AssortmentPack>();

    public virtual TblDepartment? DepParentDepartment { get; set; }

    public virtual ICollection<TblDepartment> InverseDepParentDepartment { get; set; } = new List<TblDepartment>();

    public virtual ICollection<TblDepartmentProduct> TblDepartmentProducts { get; set; } = new List<TblDepartmentProduct>();

    public virtual ICollection<TblStoreDepartmentCategory> TblStoreDepartmentCategories { get; set; } = new List<TblStoreDepartmentCategory>();

    public virtual ICollection<TblStoreDepartment> TblStoreDepartments { get; set; } = new List<TblStoreDepartment>();
}
