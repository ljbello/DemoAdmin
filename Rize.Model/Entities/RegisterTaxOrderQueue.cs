using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class RegisterTaxOrderQueue
{
    public int OrderId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
