using Microsoft.Graph;
using Microsoft.Graph.Models.Security;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.ViewModels;
using Rize.Admin.Services.Interface;
using Rize.Model.Entities;
using System.Net.NetworkInformation;
using Telerik.SvgIcons;
using System.Security.Principal;
using Microsoft.AspNetCore.Http;

namespace Rize.Admin.Services.Services
{
    public class AccountService : IAccountService
    {
        #region Fields
        private readonly IAccountDS _accountDS;
        private readonly IHttpContextAccessor _context;
        #endregion

        #region Ctor
        public AccountService(IAccountDS accountDS,  IHttpContextAccessor context)
        {
            _accountDS = accountDS;
            _context = context;
        }
        #endregion

        #region Methods

        public async Task<List<MenuUIVM>> GetMenusByUserId(int userId)
        {
            var menus = await _accountDS.GetMenusByUserId(userId);
            menus = this.OrganizeMenuTree(menus);
            return menus;
        }

        public List<MenuUIVM> OrganizeMenuTree(List<MenuUIVM> menuList)
        {
            // Create a dictionary to easily reference each node by its TreeNodeID
            var menuDict = menuList.ToDictionary(m => m.TreeNodeID);

            // List to store the top-level menus (those without parents)
            var rootMenus = new List<MenuUIVM>();

            foreach (var menu in menuList)
            {
                // If the menu has a parent, add it to the parent's Submenus collection
                if (menu.ParentTreeNodeID.HasValue && menuDict.ContainsKey(menu.ParentTreeNodeID.Value))
                {
                    var parentMenu = menuDict[menu.ParentTreeNodeID.Value];
                    parentMenu.Submenus ??= new List<MenuUIVM>();

                    parentMenu.Submenus.Add(menu);
                }
                else
                {
                    // If the menu doesn't have a parent, it's a root menu
                    rootMenus.Add(menu);
                }
            }

            return rootMenus;
        }      
    }

        #endregion

    
}
