using Microsoft.EntityFrameworkCore;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.ViewModels;
using Rize.Model.ApplicationDBcontext;
using Dapper;

namespace Rize.Admin.Data.DataServices
{
    public class AccountDS : IAccountDS
    {
        #region Fields
        private readonly IStoreProceduresDS _storeProceduresDS;
        private readonly CDEntities _db;
        #endregion

        #region Ctor
        public AccountDS(IStoreProceduresDS storeProceduresDS, CDEntities db)
        {
            _storeProceduresDS = storeProceduresDS;
            _db = db;
        }
        #endregion

        #region Methods
        public async Task<List<MenuUIVM>> GetMenusByUserId(int userId)
        {            
            var menus = await Task.FromResult(_storeProceduresDS.ExecuteStoredProcList<MenuUIVM>("Admin_GetTreeNodesByUserId", _db.Database.GetDbConnection().ConnectionString, new DynamicParameters(new { userId })));
            return menus.Where(x=>x.MenuType > 0).ToList();
        }
        #endregion
    }
}
