using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblDepartmentProduct
{
    public int DepDepartmentId { get; set; }

    public int ProProductId { get; set; }

    public int StoStoreId { get; set; }

    public virtual TblDepartment DepDepartment { get; set; } = null!;

    public virtual TblProduct ProProduct { get; set; } = null!;
}
