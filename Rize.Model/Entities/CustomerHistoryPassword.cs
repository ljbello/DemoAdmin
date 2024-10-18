using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerHistoryPassword
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public string Password { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual CustomerLogin CustomerLogin { get; set; } = null!;
}
