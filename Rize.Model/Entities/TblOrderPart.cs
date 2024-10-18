using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderPart
{
    public int ParOrderPartId { get; set; }

    public int OrdOrderId { get; set; }

    public int SupSupplierId { get; set; }

    public int? ParCxmlpart { get; set; }

    public int? ParIcsmxmlpart { get; set; }

    public DateTime? DelinquentInvoiceEmailSent { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Order OrdOrder { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}
