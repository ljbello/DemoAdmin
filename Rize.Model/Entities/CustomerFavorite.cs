using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerFavorite
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public int ProductId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual TblProduct Product { get; set; } = null!;
}
