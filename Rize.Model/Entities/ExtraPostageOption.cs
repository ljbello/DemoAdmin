using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ExtraPostageOption
{
    public int Id { get; set; }

    public int VariationId { get; set; }

    public int? PaperStockFinishId { get; set; }

    public int? SupplierEnvelopeId { get; set; }
}
