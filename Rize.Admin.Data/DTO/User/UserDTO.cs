namespace Rize.Admin.Data.DTO.User
{
    public class UserDTO
    {
        public UserDTO()
        {
            
        }

        public int EmployeeId { get; set; } = 0;
        public string FirstName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Initials { get; set; } = "";    
        public bool IsActive { get; set; } = true;
        public int DepartmentId { get; set; } = 0;
        public string Username { get; set; } = "";
        public string Department { get; set; } = "";
        public bool IsSeasonalTemp { get; set; } = false;
        public string Nickname { get; set; } = "";
        public int? SupervisorId { get; set; } = 0;
        public DateOnly? Birthday { get; set; } = null;
        public string PhoneOffice { get; set; } = "";
        public string PhoneMobile { get; set; } = "";
        public string SkypeId { get; set; } = "";
        public string GoogleId { get; set; } = "";
        public string DefaultStartPage { get; set; } = "";
        public string Gender { get; set; } = "";
        public string EmployeeNumber { get; set; } = "";
        public string Company { get; set; } = "";
        public string Title { get; set; } = "";
        public string TitleDescription { get; set; } = "";
        public string Notes { get; set; } = "";
        public DateTime? LastLogin { get; set; } = null;   
        public string EmailAddress { get; set; } = "";
        public int UserId { get; set; } = 0;
        public Guid RowGuid { get; set; } = new Guid();
        public string RoleName { get; set; } = "";
    }
}
