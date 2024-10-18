using Rize.Admin.Data.ViewModels;

namespace Rize.Admin.Data.DataServices.Interfaces
{
    public interface IAccountDS
    {
        Task<List<MenuUIVM>> GetMenusByUserId(int userId);
    }
}
