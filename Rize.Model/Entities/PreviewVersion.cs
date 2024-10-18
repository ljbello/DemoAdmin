using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PreviewVersion
{
    public int Id { get; set; }

    public int PreviewVersionId { get; set; }

    public string PreviewVersionName { get; set; } = null!;
}
