using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCatalog
{
    public int CatCatalogId { get; set; }

    public string CatTitle { get; set; } = null!;

    public string CatCode { get; set; } = null!;

    public int? CatDisplaySequence { get; set; }

    public string? CatSearchPrefix { get; set; }

    public int StoreId { get; set; }

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? ImageName { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual TblUser ModifiedByNavigation { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual ICollection<TblCustomerCatalogRequestCatalog> TblCustomerCatalogRequestCatalogs { get; set; } = new List<TblCustomerCatalogRequestCatalog>();
}
