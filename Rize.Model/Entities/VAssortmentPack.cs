using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VAssortmentPack
{
    public string Name { get; set; } = null!;

    public string PackUrl { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int? DepartmentLevel { get; set; }

    public int? DepSort { get; set; }

    public string? DepartmentName { get; set; }

    public string? DepartmentUrl { get; set; }

    public string ProductNumber { get; set; } = null!;

    public int SupplierId { get; set; }

    public string? SupplierProductNumber { get; set; }

    public string? ManufacturerProductNumber { get; set; }

    public decimal? Price { get; set; }

    public string? AdditionalKeywords { get; set; }

    public int EntityRank { get; set; }

    public string Description { get; set; } = null!;

    public int NumberPerDesign { get; set; }

    public int NumberOfDesigns { get; set; }

    public int CardsInPack { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public bool EntityInactive { get; set; }

    public DateTime EntityCreated { get; set; }

    public int ProductId { get; set; }

    public int? ProductStatusId { get; set; }

    public string? MetaTitle { get; set; }

    public int StoStoreId { get; set; }

    public DateTime? ActiveDate { get; set; }

    public bool? HasEnvelopes { get; set; }
}
