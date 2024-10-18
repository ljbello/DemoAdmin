using Kendo.Mvc.UI;
using Rize.Model.Entities;

namespace Rize.Admin.Data.DataServices.Interfaces
{

    /// <summary>
    /// Store Data Service.
    /// </summary>
    public interface IStoreDS
    {
        /// <summary>
        /// Get all the active Stores.
        /// </summary>
        /// <returns><List<Store>></returns>
        Task<DataSourceResult> GetStores(DataSourceRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Store</returns>
        Task<Store> GetStore(int id);

        /// <summary>
        ///  Create Store
        /// </summary>
        /// <param name="storeModel"></param>
        /// <returns>StoreShortVM</returns>

        Task<Store> CreateStore(Store storeModel);

        /// <summary>
        /// Update Store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="store"></param>
        /// <returns></returns>
        Task<Store> UpdateStore(int id, Store store);
    }        
}
