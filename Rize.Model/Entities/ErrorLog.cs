using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ErrorLog
{
    public long ErrorLogId { get; set; }

    public string? ProcName { get; set; }

    public DateTime? ErrorDate { get; set; }

    public string? ErrorMessage { get; set; }
}
