using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierConfig
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
