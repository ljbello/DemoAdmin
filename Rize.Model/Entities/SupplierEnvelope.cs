using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierEnvelope
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public int SupplierEnvelopeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
