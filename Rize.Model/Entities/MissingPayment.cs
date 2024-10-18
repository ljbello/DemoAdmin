using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MissingPayment
{
    public string? CardType { get; set; }

    public string? CardNumber { get; set; }

    public string? TransType { get; set; }

    public decimal? Amount { get; set; }

    public string? RespCode { get; set; }

    public string? AvsrespCode { get; set; }

    public string? CvvrespCode { get; set; }

    public DateTime? Date { get; set; }

    public string? OrderNumber { get; set; }

    public double? F10 { get; set; }

    public string? Notes { get; set; }
}
