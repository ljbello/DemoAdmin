using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CatalogUnsubcribe
{
    public int CatalogUnsubcribeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Company { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? PromoCode { get; set; }

    public int? StoreId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
