namespace Rize.Admin.Services.MicrosoftGraph.Rest
{
    public interface IGraphApiOperations
    {
        Task<dynamic> GetUserInformation(string accessToken);
        Task<string> GetPhotoAsBase64Async(string accessToken);

        Task<IDictionary<string, string>> EnumerateTenantsIdAndNameAccessibleByUser(IEnumerable<string> tenantIds, Func<string, Task<string>> getTokenForTenant);
    }
}