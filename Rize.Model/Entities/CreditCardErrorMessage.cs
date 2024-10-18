using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CreditCardErrorMessage
{
    public string HostResponseCode { get; set; } = null!;

    public string FriendlyErrorMessage { get; set; } = null!;
}
