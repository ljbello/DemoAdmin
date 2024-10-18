using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerArtworkCodeMapping
{
    public Guid CustomerArtworkdId { get; set; }

    public string Code { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
