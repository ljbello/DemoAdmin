using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderlineMailingAddress
{
    public int Id { get; set; }

    public int OrderlineId { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public string? Line1 { get; set; }

    public string? Line2 { get; set; }

    public string? Line3 { get; set; }

    public string? Line4 { get; set; }

    public string? Line5 { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool IsValid { get; set; }

    public string? ErrorCode { get; set; }

    public bool PrintAddressing { get; set; }

    public bool PrintReturnAddress { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public int StampTypeId { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblOrderLine Orderline { get; set; } = null!;
}
