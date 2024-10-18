using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TaxCity
{
    public int Id { get; set; }

    public string CityName { get; set; } = null!;

    public string StateId { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public string Synonym { get; set; } = null!;
}
