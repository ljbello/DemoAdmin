using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomerGrouping
{
    public Guid CusGroupId { get; set; }

    public int CusCustomerId { get; set; }

    public int CusMatchType { get; set; }

    public bool CusMaster { get; set; }

    public DateTime CusDateCreated { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual TblCustomer CusCustomer { get; set; } = null!;
}
