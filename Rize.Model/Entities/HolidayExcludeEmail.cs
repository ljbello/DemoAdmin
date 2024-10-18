using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class HolidayExcludeEmail
{
    public string EmailAddress { get; set; } = null!;

    public int StoreId { get; set; }

    public bool? IsAdded { get; set; }

    public DateTime? CreatedDate { get; set; }
}
