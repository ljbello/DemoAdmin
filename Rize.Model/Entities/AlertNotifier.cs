using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AlertNotifier
{
    public int AlertNotifier1 { get; set; }

    public int AlertMainId { get; set; }

    public int AlertRecipientId { get; set; }

    public bool IsActive { get; set; }

    public DateTime InsertDate { get; set; }
}
