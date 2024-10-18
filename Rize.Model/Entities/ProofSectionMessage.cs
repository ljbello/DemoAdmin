using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProofSectionMessage
{
    public int Id { get; set; }

    public int OrderLineId { get; set; }

    public string SectionName { get; set; } = null!;

    public string Message { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual TblOrderLine OrderLine { get; set; } = null!;
}
