using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VAutoProcessOrder
{
    public int OrdOrderId { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? OrdPlacedDate { get; set; }

    public string? CusEmail { get; set; }
}
