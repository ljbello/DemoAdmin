using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VertexProductCode
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }
}
