namespace Rize.Admin.Data.ViewModels.Users
{
    public class CreateUserVM
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public int SupervisorId { get; set; }
        public string Role { get; set; }
    }
}
