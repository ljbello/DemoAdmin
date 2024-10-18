using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rize.Admin.Services.MicrosoftGraph.ARMAPI
{
    public interface IArmOperations
    {
        Task<IEnumerable<string>> EnumerateTenantsIdsAccessibleByUser(string accessToken);
    }
}