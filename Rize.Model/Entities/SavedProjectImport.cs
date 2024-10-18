using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SavedProjectImport
{
    public int SavedProjectId { get; set; }

    public bool IsPersonalizationImported { get; set; }

    public int DesignId { get; set; }

    public int DocumentId { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? ConversionError { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? CustomerEmail { get; set; }
}
