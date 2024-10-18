using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SampleRequestEmailReminder
{
    public int Id { get; set; }

    public int OrdOrderId { get; set; }

    public string OrdContactEmail { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public Guid? EmailId { get; set; }

    public int EmailNumber { get; set; }
}
