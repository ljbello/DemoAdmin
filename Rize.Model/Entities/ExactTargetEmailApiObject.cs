using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ExactTargetEmailApiObject
{
    public Guid ExactTargetEmailId { get; set; }

    public string RequestId { get; set; } = null!;

    public int Sequence { get; set; }

    public string? ApiObjectXml { get; set; }

    public string? ReturnXml { get; set; }

    public bool? IsSuccessful { get; set; }

    public bool? HasResponse { get; set; }
}
