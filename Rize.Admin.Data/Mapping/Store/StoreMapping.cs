using Rize.Admin.Data.DTO.Store;

namespace Rize.Admin.Data.Mapping.Store
{
    public static class StoreMapping
    {
        public static StoreShortDTO MapToShortVM(Rize.Model.Entities.Store store)
        {
            return new StoreShortDTO
            {
                StoreID = store.StoreID,
                ShortName = store.StoNameForWebPageTitles,
                StoDescription = store.StoDescription,
                StoCode = store.StoCode,
                StoDomain = store.StoDomain,
                StoNameForWebPageTitles = store.StoNameForWebPageTitles,
                AllowAOP = store.AllowAop,
                LayoutTemplate = store.LayoutTemplate,
                StartDate = store.StartDate,
                EndDate = store.EndDate,
            };
        }
    }
}
