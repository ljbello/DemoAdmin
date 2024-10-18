using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PersonalizationThumbnail
{
    public Guid Id { get; set; }

    public string SectionName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string EmailId { get; set; } = null!;

    public bool? Extracted { get; set; }
}
