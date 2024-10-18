using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PromoCodeType
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }
}
