using Microsoft.AspNetCore.Mvc;
using Rize.Admin.Services.Interface;

namespace RIZE.AdminWeb.Components
{
    public class SidebarMenuViewComponent : ViewComponent
    {

        private readonly IAccountService _accountService;

        public SidebarMenuViewComponent(IAccountService accountService)
        {
            _accountService = accountService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Add your logic to fetch the sidebar items, such as from user privileges or database
            var menuItems = await _accountService.GetMenusByUserId(2121065); // Example method
            return View(menuItems);
        }
    }
}
