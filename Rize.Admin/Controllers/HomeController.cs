using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using Rize.Admin.Services.Interface;
using RIZE.AdminWeb.Attributes;
using RIZE.AdminWeb.Models;
using System.Diagnostics;

namespace RIZE.AdminWeb.Controllers
{
    [Authorize]
    [AuthorizeForScopes(Scopes = new[] { "User.Read" })]
    [RizeAuth]
    public class HomeController : Controller
    {
        private readonly IAccountService _accountService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IAccountService accountService, ILogger<HomeController> logger)
        {
            _accountService = accountService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Performance()
        {
            return View();
        }

        [Route("Home/Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View("~/Views/Shared/Errors/Error.cshtml", new ErrorVM { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/NotFound")]
        public IActionResult NotFound()
        {
            return View("~/Views/Shared/Errors/NotFound.cshtml");
        }
    }
}
