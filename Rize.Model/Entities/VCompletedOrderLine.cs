using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VCompletedOrderLine
{
    public int ProProductId { get; set; }

    public int OrdLinQuantity { get; set; }

    public int? OrdStaOrderStatusId { get; set; }

    public int? OrdLinReferenceProductId { get; set; }

    public int ParOrderPartId { get; set; }

    public int OrdOrderId { get; set; }

    public DateTime? OrdPlacedDate { get; set; }
}
