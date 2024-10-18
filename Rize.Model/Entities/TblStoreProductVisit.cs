using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreProductVisit
{
    public int StoProVisStoreProductVisitId { get; set; }

    public int StoStoreId { get; set; }

    public int ProProductId { get; set; }

    public DateTime VisitDateTime { get; set; }
}
