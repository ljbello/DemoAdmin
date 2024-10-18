using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GettblOrderInvoice
{
    public int OrdOrderid { get; set; }

    public decimal? OrdInvInvoiceSubTotal { get; set; }

    public decimal? OrdInvInvoiceShipping { get; set; }
}
