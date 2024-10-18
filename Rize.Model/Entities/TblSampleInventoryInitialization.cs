using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSampleInventoryInitialization
{
    public int SamInvIniSampleInventoryInitializationId { get; set; }

    public int SamInvIniNumberOfMatchesFound { get; set; }

    public string? SamInvIniProposedManufacturerProductNumber { get; set; }

    public DateTime SamInvIniTimeStamp { get; set; }

    public int? SamInvIniProposedSupplierId { get; set; }

    public int SamInvIniProposedQuantity { get; set; }

    public string? SamInvIniProposedSupplierProductNumber { get; set; }

    public bool SamInvIniInitializationInsteadOfUpdate { get; set; }
}
