using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomerCatalogRequestCode
{
    public string CusCatReqProCodCustomerCatalogRequestPromotionCodeId { get; set; } = null!;

    public string CusCatReqProCodDescription { get; set; } = null!;

    public virtual ICollection<TblCustomerCatalogRequest> TblCustomerCatalogRequests { get; set; } = new List<TblCustomerCatalogRequest>();
}
