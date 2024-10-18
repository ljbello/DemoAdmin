using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerLogin
{
    public Guid Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Guid CustomerGroupId { get; set; }

    public Guid? PasswordResetToken { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? TokenCreationDate { get; set; }

    public int StoreId { get; set; }

    public DateTime? LastLogin { get; set; }

    public int AttemptCount { get; set; }

    public DateTime? LockoutEndDate { get; set; }

    public virtual ICollection<BvfeedEntry> BvfeedEntries { get; set; } = new List<BvfeedEntry>();

    public virtual CustomerAccount? CustomerAccount { get; set; }

    public virtual ICollection<CustomerGallery> CustomerGalleries { get; set; } = new List<CustomerGallery>();

    public virtual ICollection<CustomerHistoryPassword> CustomerHistoryPasswords { get; set; } = new List<CustomerHistoryPassword>();

    public virtual ICollection<SavedProject> SavedProjects { get; set; } = new List<SavedProject>();
}
