using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoProductImportLog
{
    public DateTime CreatedOn { get; set; }

    public string Message { get; set; } = null!;
}
