using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BvfeedEntry
{
    public int BvfeedEntryId { get; set; }

    public int ProductId { get; set; }

    public string EntryText { get; set; } = null!;

    public int EntryTypeId { get; set; }

    public int? Rating { get; set; }

    public int? ParentId { get; set; }

    public string? UserProfileName { get; set; }

    public DateTime? SubmissionTime { get; set; }

    public string? Title { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int StoreId { get; set; }

    public byte[]? ProductPhoto { get; set; }

    public int? OrderId { get; set; }

    public bool Approved { get; set; }

    public int Status { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public string? InternalNotes { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public virtual CustomerLogin? CustomerLogin { get; set; }

    public virtual ICollection<CustomerReviewPhoto> CustomerReviewPhotos { get; set; } = new List<CustomerReviewPhoto>();

    public virtual TblProduct Product { get; set; } = null!;
}
