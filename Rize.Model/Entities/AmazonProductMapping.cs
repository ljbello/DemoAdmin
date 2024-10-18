using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AmazonProductMapping
{
    public string AmazonSku { get; set; } = null!;

    public int AmazonQtyPerPack { get; set; }

    public int ProductId { get; set; }

    public int? VariationId { get; set; }

    public int? PaperStockFinishId { get; set; }

    public int? SupplierEnvelopeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual PaperStockFinish? PaperStockFinish { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual TblSupplierEnvelope? SupplierEnvelope { get; set; }

    public virtual ProductVariation? Variation { get; set; }
}
