
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.EntityFrameworkCore;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.DTO.User;
using Rize.Admin.Data.Mapping.User;
using Rize.Admin.Data.ViewModels;
using Rize.Model.ApplicationDBcontext;
using Rize.Model.Entities;
using Telerik.SvgIcons;


namespace Rize.Admin.Data.DataServices
{
    public class UserDS : IUserDS
    {
        #region fields
        private readonly IStoreProceduresDS _storeProceduresDS;
        private readonly CDEntities _db;
        #endregion

        #region ctor
        public UserDS(IStoreProceduresDS storeProceduresDS, CDEntities db)
        {
            _storeProceduresDS = storeProceduresDS;
            _db = db;
        }

        #endregion

        #region Data Services

        public async Task<DataSourceResult> GetUsers(DataSourceRequest request)
        {
            var users = await (from emp in _db.TblCompanyEmployees
                               join dep in _db.TblCompanyDepartments on emp.ComDepCompanyDepartmentId equals dep.ComDepCompanyDepartmentId
                               join usr in _db.TblUsers on emp.ComEmpCompanyEmployeeId equals usr.EmployeeId
                               where usr.EmployeeId != 1
                               select new UserDTO
                               {
                                   EmployeeId = emp.ComEmpCompanyEmployeeId,
                                   FirstName = emp.ComEmpFirstName,
                                   MiddleInitial = emp.ComEmpMiddleInitial ?? "",
                                   LastName = emp.ComEmpLastName,
                                   Initials = emp.ComEmpInitials,
                                   IsActive = emp.ComEmpStaCompanyEmployeeStatusId == 1,
                                   DepartmentId = dep.ComDepCompanyDepartmentId,
                                   Department = dep.ComDepDescription ?? string.Empty,
                                   IsSeasonalTemp = emp.IsSeasonalTemp,
                                   Nickname = emp.Nickname ?? string.Empty,
                                   SupervisorId = emp.SupervisorId,
                                   Birthday = emp.Birthday,
                                   PhoneOffice = emp.PhoneOffice ?? string.Empty,
                                   PhoneMobile = emp.PhoneMobile ?? string.Empty,
                                   SkypeId = emp.SkypeId ?? string.Empty,
                                   GoogleId = emp.GoogleId ?? string.Empty,
                                   DefaultStartPage = emp.DefaultStartPage ?? string.Empty,
                                   Gender = emp.Gender.ToString() ?? "",
                                   EmployeeNumber = emp.EmployeeNumber ?? string.Empty,
                                   Company = emp.Company ?? string.Empty,
                                   Title = emp.Title ?? string.Empty,
                                   TitleDescription = emp.TitleDescription ?? string.Empty,
                                   Notes = emp.Notes ?? string.Empty,
                                   LastLogin = usr.LastLogin,
                                   EmailAddress = !string.IsNullOrEmpty(usr.EmailAddress) ? usr.EmailAddress : string.Empty,
                                   UserId = usr.UserId,
                                   RowGuid = usr.Rowguid,
                                   RoleName = string.Join(", ", (from ur in _db.AdminUserRoles
                                                                 join r in _db.AdminRoles on ur.RoleId equals r.RoleId
                                                                 where ur.UserId == usr.UserId
                                                                 orderby r.RoleId
                                                                 select r.Name).ToList())
                               }).AsNoTracking().ToDataSourceResultAsync(request);

            return users;
        }


        public async Task<UserDTO> GetUserByEmail(string email, bool asNoTracking = false)
        {

            var user = new TblUser();
            if (asNoTracking)
            {
                user = await _db.TblUsers.AsNoTracking().FirstOrDefaultAsync(x => x.EmailAddress!.ToLower() == email.ToLower());
            }
            else
            {
                user = await _db.TblUsers.FirstOrDefaultAsync(x => x.EmailAddress!.ToLower() == email.ToLower());
            }
            return UserMapping.MapToUserDTO(user);
        }

        public async Task<UserDTO> GetUserById(int id, bool asNoTracking = false)
        {
            var user = new TblUser();
            if (asNoTracking)
            {
                user = await _db.TblUsers.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == id);
            }
            else
            {
                user = await _db.TblUsers.FirstOrDefaultAsync(x => x.UserId == id);
            }

            return UserMapping.MapToUserDTO(user);
        }

        public async Task<UserDTO> CreateUser(UserDTO userDTO)
        {
            var user = UserMapping.MapToUser(userDTO);
            _db.TblUsers.Add(user);
            await _db.SaveChangesAsync();

            return UserMapping.MapToUserDTO(user);
        }

        public async Task<List<TblUserDepartment>> GetUserDepartments()
        {
            return await _db.TblUserDepartments.ToListAsync();
        }

        public async Task<List<BasicIdNameVM>> GetEmployees()
        {
            return await _db.TblCompanyEmployees.Where(x => x.IsSeasonalTemp == false && x.ComEmpStaCompanyEmployeeStatusId == 1)
                .Select(x => new BasicIdNameVM()
                {
                    Id = x.ComEmpCompanyEmployeeId,
                    Name = x.ComEmpFirstName + " " + x.ComEmpLastName
                }).ToListAsync();
        }


        public async Task<TblCompanyEmployee> CreateEmployee(TblCompanyEmployee employee)
        {
            _db.TblCompanyEmployees.Add(employee);
            await _db.SaveChangesAsync();
            return employee;
        }
        #endregion
    }
}
