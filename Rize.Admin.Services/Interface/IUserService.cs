using Kendo.Mvc.UI;
using Microsoft.Graph.Models;
using Rize.Admin.Data.DTO.User;
using Rize.Admin.Data.ViewModels;
using Rize.Admin.Data.ViewModels.Users;
using Rize.Model.Entities;

namespace Rize.Admin.Services.Interface
{
    public interface IUserService
    {
        Task<DataSourceResult> GetUsers(DataSourceRequest request);
        Task<UserDTO> GetUserByEmail(string email);
        Task<UserDTO> GetUserById(int id);
        //Task<User> GetUserByEmailAsync(string email);
        Task<UserDTO> CreateUser(CreateUserVM newUser);
        Task<List<TblUserDepartment>> GetUserDepartments();

        Task<List<BasicIdNameVM>> GetEmployees();
    }
}
