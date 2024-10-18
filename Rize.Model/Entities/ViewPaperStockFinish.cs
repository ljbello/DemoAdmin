using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewPaperStockFinish
{
    public int PaperStockFinishId { get; set; }

    public int PaperFinishId { get; set; }

    public int PaperStockId { get; set; }

    public int? SortId { get; set; }

    public int? ProductCount { get; set; }

    public string? InternalName { get; set; }

    public string? DisplayName { get; set; }

    public string? ImageName { get; set; }

    public string? Description { get; set; }

    public string? Disclaimer { get; set; }

    public string? PaperFinishName { get; set; }

    public string? SupplierPaperFinishCode { get; set; }

    public string? SupplierPaperWeightCode { get; set; }

    public string? SupplierPaperColorCode { get; set; }

    public string? PaperStockImage { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
