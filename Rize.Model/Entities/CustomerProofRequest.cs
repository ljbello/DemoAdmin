using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerProofRequest
{
    public Guid ProofRequestId { get; set; }

    public Guid OrderGuid { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? SubmittedOn { get; set; }

    public int CreatedBy { get; set; }

    public int? SubmittedBy { get; set; }

    public long CustomerProofRequestId { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<OrderlineSectionProof> OrderlineSectionProofs { get; set; } = new List<OrderlineSectionProof>();

    public virtual TblUser? SubmittedByNavigation { get; set; }
}
