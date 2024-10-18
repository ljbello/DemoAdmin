using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AlertRecipient
{
    public int AlertRecipientId { get; set; }

    public string AlertRecipientName { get; set; } = null!;

    public string AlertRecipientEmail { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime InsertDate { get; set; }
}
