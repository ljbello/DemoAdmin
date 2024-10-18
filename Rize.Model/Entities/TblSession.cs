using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSession
{
    public Guid SessionGuid { get; set; }

    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? DateCreated { get; set; }
}
