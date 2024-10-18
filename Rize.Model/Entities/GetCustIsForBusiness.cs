using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetCustIsForBusiness
{
    public int CustomerId { get; set; }

    public bool IsForBusiness { get; set; }
}
