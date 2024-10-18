using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class LegacyOrderHeader
{
    public string? OrderStatusCode { get; set; }

    public string? OrderStatus { get; set; }

    public string? AnsweredAs { get; set; }

    public long OrderNumber { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Name { get; set; }

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public decimal? Merchandise { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Shipping { get; set; }

    public string? BillAddr1 { get; set; }

    public string? BillAddr2 { get; set; }

    public string? BillAddrCity { get; set; }

    public string? BillAddrState { get; set; }

    public string? BillAddrZip { get; set; }

    public string? Ponumber { get; set; }

    public string? ConfirmationNumber { get; set; }

    public string? PromoCode { get; set; }

    public int? StoreId { get; set; }

    public Guid? CustomerLoginId { get; set; }
}
