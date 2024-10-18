using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Forecast
{
    public DateOnly ForecastMonth { get; set; }

    public int StoreId { get; set; }

    public decimal? ForecastAmount { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
