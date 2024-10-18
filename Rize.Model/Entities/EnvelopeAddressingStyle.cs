using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EnvelopeAddressingStyle
{
    public int Id { get; set; }

    public int Number { get; set; }

    public int LayoutId { get; set; }

    public bool Active { get; set; }

    public bool ValidateAllCaps { get; set; }

    public string? ValidateLines { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Layout Layout { get; set; } = null!;
}
