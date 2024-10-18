using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomer
{
    public int CusCustomerId { get; set; }

    public int StoStoreId { get; set; }

    public string? CusFirstName { get; set; }

    public string? CusLastName { get; set; }

    public string? CusEmail { get; set; }

    public bool? CusSendEmailNewsletters { get; set; }

    public DateTime? CusDateSendEmailNewsChanged { get; set; }

    public bool? CusHtmlemailFormat { get; set; }

    public bool? CusInterestBusinessGreetings { get; set; }

    public bool? CusInterestOffice { get; set; }

    public bool? CusInterestBusinessStationery { get; set; }

    public bool? CusInterestWedding { get; set; }

    public bool? CusInterestOtherInvitations { get; set; }

    public bool? CusInterestGraduation { get; set; }

    public bool? CusInterestBaby { get; set; }

    public bool? CusInterestAnniversary { get; set; }

    public bool? CusInterestPersonalStationery { get; set; }

    public DateTime? CusDateCreated { get; set; }

    public string? CusNotes { get; set; }

    public bool CusSendPaperMail { get; set; }

    public bool CusBadAddressTemp { get; set; }

    public int? CusProspect { get; set; }

    public bool CusBadEmailAddress { get; set; }

    public bool CusSolicitPhone { get; set; }

    public bool CusAnonymous { get; set; }

    public string? CusCustomerType { get; set; }

    public DateOnly? ProspectDropDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool DoNotSell { get; set; }

    public virtual Store StoStore { get; set; } = null!;

    public virtual ICollection<TblCustomerCatalogRequest> TblCustomerCatalogRequests { get; set; } = new List<TblCustomerCatalogRequest>();

    public virtual TblCustomerGrouping? TblCustomerGrouping { get; set; }
}
