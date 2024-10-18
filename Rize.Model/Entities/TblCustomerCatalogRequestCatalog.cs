using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomerCatalogRequestCatalog
{
    public int CusCatReqCustomerCatalogRequestId { get; set; }

    public int CatCatalogId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblCatalog CatCatalog { get; set; } = null!;

    public virtual TblCustomerCatalogRequest CusCatReqCustomerCatalogRequest { get; set; } = null!;
}
