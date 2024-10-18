using Kendo.Mvc.UI;
using Microsoft.Graph;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.DTO.User;
using Rize.Admin.Data.ViewModels;
using Rize.Admin.Data.ViewModels.Users;
using Rize.Admin.Services.Interface;
using Rize.Model.Entities;


namespace Rize.Admin.Services.Services
{
    public class UserService : IUserService
    {
        #region fields
        private readonly IUserDS _userDS;
        #endregion

        #region ctor
        public UserService(IUserDS userDS )
        {
            _userDS = userDS;
        }
        #endregion

        #region Services

        public async Task<DataSourceResult> GetUsers(DataSourceRequest request)
        {
            return await _userDS.GetUsers(request);
        }

        public async Task<UserDTO> GetUserByEmail(string email)
        {
            return await _userDS.GetUserByEmail(email);
        }

        public async Task<UserDTO> GetUserById(int id)
        {
            return await _userDS.GetUserById(id);
        }

        public async Task<UserDTO> CreateUser(CreateUserVM newUser)
        {
            //Check if user already exists
            var userDto = await _userDS.GetUserByEmail(newUser.EmailAddress);

            if (userDto.UserId > 0)
            {
                return userDto;
            }

            //Create or Check Employee number
            var employee = new TblCompanyEmployee
            {
                ComEmpFirstName = newUser.FirstName,
                ComEmpLastName = newUser.LastName,
                ComEmpUserName = newUser.EmailAddress.Split(new[] { '@' })[0],
                ComEmpInitials = (newUser.FirstName[0].ToString() + newUser.LastName[0].ToString()).ToUpper(),
                ComEmpUseGroCompanyEmployeeUserGroupId = 4, // AdminUser
                ComEmpStaCompanyEmployeeStatusId = 1, //Active
                ComDepCompanyDepartmentId = newUser.DepartmentId,
                IsSeasonalTemp = false,
            };

            employee = await _userDS.CreateEmployee(employee);

            //Create User
            var user = new UserDTO
            {
                EmailAddress = newUser.EmailAddress,
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Initials = employee.ComEmpInitials,
                DepartmentId = newUser.DepartmentId,
                SupervisorId = newUser.SupervisorId,
                RoleName = newUser.Role,
                EmployeeId = employee.ComEmpCompanyEmployeeId,
                RowGuid = Guid.NewGuid(),
                Username = employee.ComEmpUserName,
                IsActive = true,
                
            };

            return await _userDS.CreateUser(user);
        }

        public async Task<List<TblUserDepartment>> GetUserDepartments()
        {
            return await _userDS.GetUserDepartments();
        }

        public async Task<List<BasicIdNameVM>> GetEmployees()
        {
            return await _userDS.GetEmployees();
        }


        #endregion
    }
}
