using Rize.Admin.Data.ViewModels;

namespace Rize.Admin.Services.Interface
{
    public interface IAccountService
    {
        Task<List<MenuUIVM>> GetMenusByUserId(int userId);
    }
}
