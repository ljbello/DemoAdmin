using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetCustomerType
{
    public int CusCustomerId { get; set; }

    public string IsForBusiness { get; set; } = null!;
}
