using Kendo.Mvc.UI;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.DTO.Store;
using Rize.Admin.Services.Interface;
using Rize.Cache.Services;
using Rize.Model.Entities;
using Rize.Admin.Data.Mapping.Store;

namespace Rize.Admin.Services.Services
{
    public class StoreService : IStoreService
    {
        #region fields
        private readonly IStoreDS _storeDataService;
        private readonly IRizeCacheService _rizeCacheService;
        #endregion

        #region ctor
        public StoreService(IStoreDS storeDataService, IRizeCacheService rizeCacheService)
        {
            _storeDataService = storeDataService;
            _rizeCacheService = rizeCacheService;
        }
        #endregion

        #region services
        public async Task<DataSourceResult> GetStores(DataSourceRequest request)
        {

            var stores = await _storeDataService.GetStores(request);
            return stores; 
        }

        public async Task<Store> GetStore(int id)
        {
            var store = _rizeCacheService.GetCacheKey<Store>($"store_{id}");
            if (store == null)
            {
                store = await _storeDataService.GetStore(id);

                if (store != null)
                {
                    _rizeCacheService.SetCacheKey($"store_{id}", store);
                    return store;
                }
            }
            return store;
        }

        public async Task<StoreShortDTO> CreateStore(Store storeModel)
        {
            var store = await _storeDataService.CreateStore(storeModel);
            return StoreMapping.MapToShortVM(store);   
        }
        public async Task<Store> UpdateStore(int id, Store store)
        {
            return await _storeDataService.UpdateStore(id, store);
        }

        #endregion

    }
}
