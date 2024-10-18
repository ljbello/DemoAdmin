using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CorporateBilling
{
    public Guid Id { get; set; }

    public string? AccountsPayableContact { get; set; }

    public string? FaxNumber { get; set; }

    public string? EmailAddress { get; set; }

    public int? YearsInBusiness { get; set; }

    public string? OperatesFrom { get; set; }

    public string? PurchaseOrder { get; set; }
}
