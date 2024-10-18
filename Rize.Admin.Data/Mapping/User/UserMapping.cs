using Rize.Admin.Data.DTO.User;
using Rize.Model.Entities;

namespace Rize.Admin.Data.Mapping.User
{
    public static class UserMapping
    {
        public static UserDTO MapToUserDTO(TblUser? user)
        {
            if (user == null)
                return new UserDTO();

            return new UserDTO
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleInitial = user.MiddleInitial!,
                Initials = user.Initials,
                EmailAddress = user.EmailAddress!,
                IsActive = Convert.ToBoolean(user.Active),
                DepartmentId = user.DepartmentId,
                Department = user.Department?.Description!,
                LastLogin = user.LastLogin,
                RowGuid = user.Rowguid,
            };
        }
        public static TblUser MapToUser(UserDTO userDto)
        {
            if (userDto == null)
                return new TblUser();

            return new TblUser
            {
                UserId = userDto.UserId,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                MiddleInitial = userDto.MiddleInitial,
                Initials = userDto.Initials,
                EmailAddress = userDto.EmailAddress,
                Active = userDto.IsActive,
                DepartmentId = userDto.DepartmentId,               
                LastLogin = userDto.LastLogin,
                Rowguid = userDto.RowGuid,
                EmployeeId = userDto.EmployeeId,
                Username = userDto.Username,
            };
        }
    }
}
