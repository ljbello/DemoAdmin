using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderNote
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? EventTypeId { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedOn { get; set; }

    public int UserId { get; set; }

    public int? OrderLineId { get; set; }

    public int? StatusId { get; set; }

    public virtual OrderNoteEventType? EventType { get; set; }

    public virtual Order? Order { get; set; }

    public virtual TblOrderLine? OrderLine { get; set; }

    public virtual TblUser User { get; set; } = null!;
}
