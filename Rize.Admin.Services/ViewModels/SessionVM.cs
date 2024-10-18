namespace Rize.Admin.Services.ViewModels
{
    public class SessionVM
    {
        public UserVM User { get; set; }
        public UserProjectPermissionsVM UserPermissions { get; set; }
    }
    public class UserVM
    {
        public int Id { get; set; }
        public Guid IdentityId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int ForgotPasswordRequests { get; set; }
        public DateTime LastForgotPasswordRequestDate { get; set; }
        public string UserName { get; set; }
        public string UserStatusId { get; set; }
        public string UserStatusName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int UserCreated { get; set; }
        public int UserModified { get; set; }
        public List<UserRoleVM> UserRoles { get; set; }
        public List<UserGroupVM> UserGroups { get; set; }

    }
    public class UserRoleVM
    {
        public UserRoleVM()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Scope { get; set; }
        public int Hierarchy { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? UserModified { get; set; }
        public string UIComponentsName { get; set; }
        public int? UserCreated { get; set; }
        public List<UIUserRoleComponentPermissionVM> UserRolePermissions { get; set; }
    }
    public class UserGroupVM
    {
        public UserGroupVM()
        {
            
        }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? UserModified { get; set; }
        public int? UserCreated { get; set; }
        public List<UserVM>? Users { get; set; }
    }
    public class UIUserRoleComponentPermissionVM
    {
        public UIUserRoleComponentPermissionVM()
        {
            
        }
        public int UserRoleId { get; set; }
        public int UserRoleScope { get; set; }
        public int ComponentId { get; set; }
        public string ComponentTag { get; set; }
        public int ComponentPermissionValue { get; set; }
        public string ComponentPermissionName { get; set; }
        public int ComponentTypeId { get; set; }
        public string ComponentTypeName { get; set; }
        public bool IsDeleted { get; set; }
        public int UserCreated { get; set; }
    }
    public class UserProjectPermissionsVM
    {
        public UserProjectPermissionsVM()
        {
            
        }
        public int UserId { get; set; }
        public List<UserRoleVM> UserRoles { get; set; }
        public List<UIUserRoleComponentPermissionVM> UIComponentPermissions { get; set; }
        public List<UserProjectResourceActionVM> ProjectResourceActions { get; set; }

    }
    public class UserProjectResourceActionVM
    {
        public UserProjectResourceActionVM()
        {
            
        }
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public int UserProjectResourceId { get; set; }
        public string ProjectName { get; set; }
        public string ControllerName { get; set; }
        public string Action { get; set; }
        public int Scope { get; set; }
    }
}
