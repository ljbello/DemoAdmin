using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VUnGroupedCustomer
{
    public int CusCustomerId { get; set; }

    public string? CusEmail { get; set; }

    public string? CusFirstName { get; set; }

    public string? CusLastName { get; set; }

    public DateTime? CusDateCreated { get; set; }
}
