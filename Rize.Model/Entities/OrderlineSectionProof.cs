using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderlineSectionProof
{
    public int Id { get; set; }

    public int OrderlineId { get; set; }

    public string SectionName { get; set; } = null!;

    public short StatusId { get; set; }

    public string? RevisionNotes { get; set; }

    public DateTime UpdatedOn { get; set; }

    public int? ModifedBy { get; set; }

    public int? CreatedBy { get; set; }

    public long ProofRequestId { get; set; }

    public virtual TblOrderLine Orderline { get; set; } = null!;

    public virtual CustomerProofRequest ProofRequest { get; set; } = null!;
}
