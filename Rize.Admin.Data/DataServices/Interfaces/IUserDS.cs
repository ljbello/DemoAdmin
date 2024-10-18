using Kendo.Mvc.UI;
using Rize.Admin.Data.DTO.User;
using Rize.Admin.Data.ViewModels;
using Rize.Admin.Data.ViewModels.Users;
using Rize.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rize.Admin.Data.DataServices.Interfaces
{
    public interface IUserDS
    {
        /// <summary>
        /// Get all the active Users.
        /// </summary>
        /// <returns><List<Users>></returns>
        Task<DataSourceResult> GetUsers(DataSourceRequest request);


        /// <summary>
        /// Get a User by email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        Task<UserDTO> GetUserByEmail(string email, bool asNoTracking = false);


        /// <summary>
        /// Get a User by email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        Task<UserDTO> GetUserById(int id, bool asNoTracking = false);

        /// <summary>
        /// Create a new User.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        Task<UserDTO> CreateUser(UserDTO userDTO);

        Task<List<TblUserDepartment>> GetUserDepartments();

        Task<List<BasicIdNameVM>> GetEmployees();


        Task<TblCompanyEmployee> CreateEmployee(TblCompanyEmployee employee);

    }
}
