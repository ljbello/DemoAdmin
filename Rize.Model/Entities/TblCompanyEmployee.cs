using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCompanyEmployee
{
    public int ComEmpCompanyEmployeeId { get; set; }

    public string ComEmpFirstName { get; set; } = null!;

    public string? ComEmpMiddleInitial { get; set; }

    public string ComEmpLastName { get; set; } = null!;

    public string ComEmpUserName { get; set; } = null!;

    public string ComEmpInitials { get; set; } = null!;

    public int ComEmpUseGroCompanyEmployeeUserGroupId { get; set; }

    public int ComEmpStaCompanyEmployeeStatusId { get; set; }

    public int ComDepCompanyDepartmentId { get; set; }

    public int? ComEmpDisplaySequenceArtwork { get; set; }

    public string? Nickname { get; set; }

    public int? SupervisorId { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? PhoneOffice { get; set; }

    public string? PhoneMobile { get; set; }

    public string? SkypeId { get; set; }

    public string? GoogleId { get; set; }

    public string? DefaultStartPage { get; set; }

    public bool IsSeasonalTemp { get; set; }

    public byte? Gender { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? Company { get; set; }

    public string? Title { get; set; }

    public string? TitleDescription { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblCompanyDepartment ComDepCompanyDepartment { get; set; } = null!;

    public virtual TblCompanyEmployeeStatus ComEmpStaCompanyEmployeeStatus { get; set; } = null!;

    public virtual TblCompanyEmployeeUserGroup ComEmpUseGroCompanyEmployeeUserGroup { get; set; } = null!;

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
