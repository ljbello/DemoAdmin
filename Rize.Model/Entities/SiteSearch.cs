using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SiteSearch
{
    public int Id { get; set; }

    public string Keyword { get; set; } = null!;

    public DateTime SearchedOn { get; set; }

    public string UserIp { get; set; } = null!;

    public string? ReferralUrl { get; set; }

    public string? RedirectedTo { get; set; }

    public int ResultSetCount { get; set; }

    public int? StoreId { get; set; }
}
