using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailSubscription
{
    public Guid EmailSubscriptionId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? BirthdayDate { get; set; }

    public bool IntrestedInHolidayCards { get; set; }

    public bool IntrestedInOccasionCards { get; set; }

    public bool IntrestedInInvitations { get; set; }

    public bool ForPersonal { get; set; }

    public bool ForBusiness { get; set; }

    public string? FrequencyOfEmails { get; set; }

    public bool IsUnsubscribed { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DateUnsubscribed { get; set; }

    public int? StoreId { get; set; }

    public string? Mobile { get; set; }

    public bool AllowSms { get; set; }
}
