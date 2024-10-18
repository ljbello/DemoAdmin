using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetCustomerGroupingContactPreference
{
    public int CusCustomerid { get; set; }

    public string EmailOk { get; set; } = null!;

    public string SnailMailOk { get; set; } = null!;

    public string PhoneOk { get; set; } = null!;
}
