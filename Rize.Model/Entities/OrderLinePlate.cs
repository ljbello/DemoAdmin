using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLinePlate
{
    public int OrderLinePlatesId { get; set; }

    public int OrderId { get; set; }

    public string? OrderNumber { get; set; }

    public int OrderLineId { get; set; }

    public bool Created { get; set; }

    public bool Locked { get; set; }

    public bool PlateError { get; set; }

    public string? PlateErrorMessage { get; set; }

    public string? MachineInstanceId { get; set; }

    public int? PreviewVersion { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreationDuration { get; set; }

    public string? Message { get; set; }

    public DateTime PlateQueueOn { get; set; }

    public int QueueBy { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual TblOrderLine OrderLine { get; set; } = null!;

    public virtual TblUser QueueByNavigation { get; set; } = null!;
}
