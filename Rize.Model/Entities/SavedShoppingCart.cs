using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SavedShoppingCart
{
    public int Id { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public int OrderId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Order Order { get; set; } = null!;
}
