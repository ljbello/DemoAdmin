using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblBatchTransmissionsOrderPart
{
    public int ParOrderPartId { get; set; }

    public int BatTraBatchTransmissionsId { get; set; }

    public int SupSupplierId { get; set; }

    public int OrdOrderId { get; set; }

    public int Id { get; set; }

    public int? Icsmxmlpart { get; set; }

    public virtual TblBatchTransmission BatTraBatchTransmissions { get; set; } = null!;

    public virtual Order OrdOrder { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;
}
