using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TmptblCatalogRequestsLabel
{
    public int Id { get; set; }

    public int CusCatReqCustomerCatalogRequestId { get; set; }

    public string? CusCatReqDateRequested { get; set; }

    public string? CusAddPhone { get; set; }

    public string? CustomerName { get; set; }

    public string? CusAddCompany { get; set; }

    public string? CusEmail { get; set; }

    public string CusAddAddress1 { get; set; } = null!;

    public string? CusAddAddress2 { get; set; }

    public string? CityStateZip { get; set; }

    public string? CatLabelCode { get; set; }

    public int? CusCustomerId { get; set; }

    public DateTime? CusDateCreated { get; set; }
}
