using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewOrderCustomerCreditInfo
{
    public Guid? CustomerLoginId { get; set; }

    public int? MaxDaysToReceive { get; set; }

    public int? MaxDaysOpen { get; set; }

    public decimal? MaxOrdersize { get; set; }

    public int ProposedCreditLimit { get; set; }
}
