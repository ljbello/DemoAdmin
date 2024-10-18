using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomerCatalogRequest
{
    public int CusCatReqCustomerCatalogRequestId { get; set; }

    public int CusCustomerId { get; set; }

    public int CusAddCustomerAddressId { get; set; }

    public DateTime CusCatReqDateRequested { get; set; }

    public int? BasBasketId { get; set; }

    public string? CusCatReqCodCustomerCatalogRequestCodeId { get; set; }

    public string? CusCatReqKeyCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? LabelPrinted { get; set; }

    public string? ExcludeReason { get; set; }

    public virtual TblBasket? BasBasket { get; set; }

    public virtual TblCustomerAddress CusAddCustomerAddress { get; set; } = null!;

    public virtual TblCustomerCatalogRequestCode? CusCatReqCodCustomerCatalogRequestCode { get; set; }

    public virtual TblCustomer CusCustomer { get; set; } = null!;

    public virtual ICollection<TblCustomerCatalogRequestCatalog> TblCustomerCatalogRequestCatalogs { get; set; } = new List<TblCustomerCatalogRequestCatalog>();
}
