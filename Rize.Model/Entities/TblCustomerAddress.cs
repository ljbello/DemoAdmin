using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomerAddress
{
    public int CusAddCustomerAddressId { get; set; }

    public int CusCustomerId { get; set; }

    public string CusAddName { get; set; } = null!;

    public string? CusAddLastName { get; set; }

    public string? CusAddCompany { get; set; }

    public string CusAddAddress1 { get; set; } = null!;

    public string? CusAddAddress2 { get; set; }

    public string CusAddCity { get; set; } = null!;

    public string StaStateId { get; set; } = null!;

    public string CusAddZip { get; set; } = null!;

    public string? CusAddPhone { get; set; }

    public string? CusAddFax { get; set; }

    public bool CusAddIsShippingAddress { get; set; }

    public string CouCountryId { get; set; } = null!;

    public string? CusAddContactTitle { get; set; }

    public string? CusAddEveningPhone { get; set; }

    public string? CusAddCleanPhone { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<MatchBackReportsSystemDataProcessed> MatchBackReportsSystemDataProcesseds { get; set; } = new List<MatchBackReportsSystemDataProcessed>();

    public virtual ICollection<TblCustomerCatalogRequest> TblCustomerCatalogRequests { get; set; } = new List<TblCustomerCatalogRequest>();
}
