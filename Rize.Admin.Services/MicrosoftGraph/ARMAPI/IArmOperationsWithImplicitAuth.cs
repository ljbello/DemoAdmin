using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rize.Admin.Services.MicrosoftGraph.ARMAPI
{
    public interface IArmOperationsWithImplicitAuth
    {
        Task<IEnumerable<string>> EnumerateTenantsIds();
    }
}
