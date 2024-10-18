using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductCategoryStage
{
    public int ProdId { get; set; }

    public string? Supplier { get; set; }

    public int? StoreId { get; set; }

    public string? Status { get; set; }

    public bool? Display { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateActive { get; set; }

    public string ProductNumber { get; set; } = null!;

    public string? ImageName { get; set; }

    public string? SupplierSku { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int ProductTypeId { get; set; }

    public int ProductionTypeId { get; set; }

    public int? ProductUseId { get; set; }

    public string? ProductType { get; set; }

    public string? ParentDepartment { get; set; }

    public string? Department { get; set; }

    public string? Occasion { get; set; }

    public string? Theme { get; set; }

    public string? Occasions { get; set; }

    public string? Themes { get; set; }

    public string? Styles { get; set; }

    public string? Collections { get; set; }

    public int? DefaultOccasionId { get; set; }

    public int? DefaultThemeId { get; set; }

    public double? MerchScore { get; set; }

    public int? Offset { get; set; }

    public int? OrderCount { get; set; }

    public int? InventoryOnHand { get; set; }

    public int? InventoryCommitted { get; set; }

    public int? InventoryInFlight { get; set; }

    public int? InventoryOrdered { get; set; }

    public int? RecentOrders { get; set; }

    public int? CartCount { get; set; }

    public int? RecentVisits { get; set; }

    public int? AgeDays { get; set; }

    public int? ReviewCount { get; set; }

    public decimal? ReviewStars { get; set; }

    public string? Designer { get; set; }

    public string? ArtSource { get; set; }

    public int Pvversion { get; set; }

    public int AllowStockSample { get; set; }

    public bool AllowCustomSample { get; set; }

    public string? PriceGroup { get; set; }
}
