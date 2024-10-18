using Microsoft.AspNetCore.Mvc;
using Rize.Admin.Services.Interface;

namespace RIZE.AdminWeb.Components
{
    public class HeaderViewComponent : ViewComponent
    {

        private readonly IAccountService _accountService;

        public HeaderViewComponent(IAccountService accountService)
        {
            _accountService = accountService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
           // await _accountService.GetLoggedUserInformation();
            return View();
        }
    }
}
