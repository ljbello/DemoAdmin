using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SaveShoppingCartReminder
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public int? OrderId { get; set; }

    public Guid? ExactTargetEmailId { get; set; }

    public DateTime CreatedOn { get; set; }
}
