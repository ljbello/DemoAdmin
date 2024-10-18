using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAuthorizationBankAccountType
{
    public int AutBanAccTypBankAccountTypeId { get; set; }

    public string AutBanAccTypDescription { get; set; } = null!;

    public int AutBanAccTypSequence { get; set; }
}
