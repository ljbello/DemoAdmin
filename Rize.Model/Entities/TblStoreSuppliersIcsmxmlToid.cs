using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreSuppliersIcsmxmlToid
{
    public int Id { get; set; }

    public int StoStoreId { get; set; }

    public int SupSupplierId { get; set; }

    public string? StoSupIcsmxmlToid { get; set; }

    public virtual Store StoStore { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;
}
