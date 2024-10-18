using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using Rize.Admin.Data.ViewModels.Users;
using Rize.Admin.Services.Enum;
using Rize.Admin.Services.Interface;
using RIZE.AdminWeb.Attributes;

namespace RIZE.AdminWeb.Controllers
{
    [Authorize]
    [AuthorizeForScopes(Scopes = new[] { "User.Read" })]
    [RizeAuth]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        #region Get
        // GET: Users
        [HttpGet("/administration/users")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet("/administration/UserList")]
        public async Task<IActionResult> UserList([DataSourceRequest] DataSourceRequest request)
        {
            var users = await _userService.GetUsers(request);

            return Json(users.Data.ToDataSourceResult(request));
        }

        [HttpGet("/administration/users/Detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user.UserId == 0 || user == null)
                return NotFound();

            return View(user);
        }

        [HttpGet("/administration/users/GetPrivileges")]
        public async Task<IActionResult> GetPrivileges()
        {
            return Ok();
        }


        [HttpGet("/administration/users/GetUserDepartments")]
        public async Task<IActionResult> GetUserDepartments()
        {
            return Json(await _userService.GetUserDepartments());
        }

        [HttpGet("/administration/users/GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            return Json(await _userService.GetEmployees());
        }
        
        #endregion

        #region Write
        [HttpPost("/administration/users/create")]
        public async Task<IActionResult> Create([FromBody] CreateUserVM newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userService.GetUserByEmail(newUser.EmailAddress);
            if (user.UserId != 0)
                return BadRequest("User already exists");

            user = await _userService.CreateUser(newUser);

            // Set TempData to trigger the toast
            TempData["ToastType"] = ToasTypes.Success;
            TempData["ToastMessage"] = $"The user {user.EmailAddress} was created successfully.";

            //TODO: Create common Json Reponse
            return Json(new { redirectUrl = Url.Action("Detail", new { id = user.UserId }) });
        }
        #endregion


    }
}
