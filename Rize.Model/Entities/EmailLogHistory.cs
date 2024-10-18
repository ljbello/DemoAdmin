using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailLogHistory
{
    public int Id { get; set; }

    public Guid EmailLogId { get; set; }

    public string? EmailContents { get; set; }
}
