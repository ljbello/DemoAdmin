using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class IntercomConversationPart
{
    public string Id { get; set; } = null!;

    public string Conversationid { get; set; } = null!;

    public string PartType { get; set; } = null!;

    public string? Body { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime NotifiedAt { get; set; }

    public string Authorid { get; set; } = null!;

    public string Authortype { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
