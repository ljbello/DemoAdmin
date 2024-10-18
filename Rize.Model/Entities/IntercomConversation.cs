using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class IntercomConversation
{
    public string Id { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ConversionMessage { get; set; }

    public string Userid { get; set; } = null!;

    public string? Assignee { get; set; }

    public bool Open { get; set; }

    public bool Read { get; set; }

    public string? Tags { get; set; }

    public string Type { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int? StoreId { get; set; }
}
