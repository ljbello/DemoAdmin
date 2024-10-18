using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblBasket
{
    public int BasBasketId { get; set; }

    public string? BasUrl { get; set; }

    public string? BasSearchEngine { get; set; }

    public string? BasSearchTerm { get; set; }

    public string? BasLandingPage { get; set; }

    public string? BasPurchasePageReferrer { get; set; }

    public string? BasPurchasePage { get; set; }

    public string? BasBrowser { get; set; }

    public string? BasIpaddress { get; set; }

    public DateTime? BasTimeSiteEntered { get; set; }

    public int? BasVisits { get; set; }

    public virtual ICollection<TblBasketItem> TblBasketItems { get; set; } = new List<TblBasketItem>();

    public virtual ICollection<TblCustomerCatalogRequest> TblCustomerCatalogRequests { get; set; } = new List<TblCustomerCatalogRequest>();
}
