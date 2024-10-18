
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.DTO.Store;
using Rize.Model.ApplicationDBcontext;
using Rize.Model.Entities;


namespace Rize.Admin.Data.DataServices
{
    public class StoreDS : IStoreDS
    {
        #region Fields
        private readonly CDEntities _db;
        #endregion

        #region Ctor
        public StoreDS(CDEntities db)
        {
            _db = db;
        }
        #endregion

        #region Services

        public async Task<DataSourceResult> GetStores(DataSourceRequest request)
        {
            var stores = await _db.TblStores.Select(x => new StoreShortDTO()
            {
                StoreID = x.StoreID,
                ShortName = x.StoNameForWebPageTitles ?? "",
                StoDescription = x.StoDescription ?? "",
                StoCode = x.StoCode ?? "",
                StoDomain = x.StoDomain ?? "",
                StoNameForWebPageTitles = x.StoNameForWebPageTitles ?? "",
                AllowAOP = x.AllowAop ?? false,
                LayoutTemplate = x.LayoutTemplate ?? "",
                StartDate = x.StartDate,
                EndDate = x.EndDate
            }).AsNoTracking().ToDataSourceResultAsync(request);
            return stores;
        }

        public async Task<Store?> GetStore(int id)
        {
            return await _db.TblStores.FirstOrDefaultAsync(s => s.StoreID == id);
        }

        public async Task<Store> CreateStore(Store storeModel)
        {
           _db.TblStores.Add(storeModel);
            await _db.SaveChangesAsync();
            return storeModel;
        }

        public async Task<Store> UpdateStore(int id, Store store)
        {
            var existingStore = await _db.TblStores.FirstOrDefaultAsync(s => s.StoreID == id);
            if (existingStore != null)
            {
                var storeType = typeof(Store);
                var properties = storeType.GetProperties();

                foreach (var property in properties)
                {
                    var value = property.GetValue(store);
                    if (value != null)
                    {
                        property.SetValue(existingStore, value);
                    }
                }

                await _db.SaveChangesAsync();
            }
            else
            {
                var newStore =  await this.CreateStore(store);
                return newStore;
            }
            return existingStore;
        }

        #endregion
    }
}

