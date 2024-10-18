using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CatalogRequestEmailReminder
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreatedOn { get; set; }
}
