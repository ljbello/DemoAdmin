using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MarketingForTheTroopsPromotion
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Message { get; set; } = null!;

    public bool EmailSubscription { get; set; }

    public DateTime CreatedDate { get; set; }
}
