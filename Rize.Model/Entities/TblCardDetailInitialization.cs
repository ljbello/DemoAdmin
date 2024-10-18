using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCardDetailInitialization
{
    public int CarDetIniCardDetailInitializationId { get; set; }

    public string CarDetIniProposedProductNumber { get; set; } = null!;

    public int CarDetIniNumberOfMatches { get; set; }

    public DateTime CarDetIniTimeStamp { get; set; }
}
