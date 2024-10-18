using Rize.Model.Entities;
using Kendo.Mvc.UI;
using Rize.Admin.Data.DTO.Store;

namespace Rize.Admin.Services.Interface
{
    public interface IStoreService
    {
        Task<DataSourceResult> GetStores(DataSourceRequest request);
        Task<Store> GetStore(int id);
        Task<StoreShortDTO> CreateStore(Store storeModel);
        Task<Store> UpdateStore(int id, Store store);
    }
}
