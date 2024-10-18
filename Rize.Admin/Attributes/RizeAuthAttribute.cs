using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Identity.Web;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Data.DTO.User;
using Rize.Admin.Services.Interface;
using Rize.Admin.Services.Services;
using Rize.Admin.Services.ViewModels;
using Rize.Cache.Services;
using static System.Net.WebRequestMethods;
using Rize.Admin.Services.MicrosoftGraph.Rest;
using Rize.Admin.Services.MicrosoftGraph;


namespace RIZE.AdminWeb.Attributes
{
    public class RizeAuthAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            bool performImpersonationCheck = true;
            var rd = context.HttpContext.GetRouteData();

            string controllerName = context.Controller.GetType().Name;
            string controllerAction = rd.Values["action"].ToString();

            if (!context.HttpContext.User.Identity.IsAuthenticated)
                throw new System.UnauthorizedAccessException("Unauthorized");

            IServiceProvider serviceProvider = context.HttpContext.RequestServices;
            IRizeCacheService _rizecache = serviceProvider.GetService<IRizeCacheService>();

            // Unique Token Identifier
            var uti = context.HttpContext.User.FindFirst("uti")?.Value;
            var email = context.HttpContext.User.FindFirst("email")?.Value ??
                        context.HttpContext.User.FindFirst("preferred_username")?.Value;

            // Check if the user has a user session in the cache
            SessionVM session = await _rizecache!.GetCacheKeyAsync<SessionVM>($"Session_{uti}");

            if (session == null)
            {
                // Session not found in cache, let's save it
                var fullname = context.HttpContext.User.FindFirst("name")?.Value;
                var lastName = fullname!.Split(",")[0].Replace(" ", "");
                var firstName = fullname.Split(",")[1].Replace(" ", "");

                // Find the user in the database
                IUserDS? _userDS = serviceProvider.GetService<IUserDS>();
                var user = await _userDS!.GetUserByEmail(email!);

                if (user == null)
                    throw new System.UnauthorizedAccessException("Unauthorized");

                // Check if first login
                if (user.LastLogin == null)
                {
                    ITokenAcquisition? tokenAcquisition = serviceProvider.GetService<ITokenAcquisition>();
                    IGraphApiOperations? graphApiOperations = serviceProvider.GetService<IGraphApiOperations>();

                    try
                    {
                        var accessToken = await tokenAcquisition!.GetAccessTokenForUserAsync(new[] { GraphConstants.ScopeUserRead });
                        dynamic me = await graphApiOperations!.GetUserInformation(accessToken);
                        var aux = me;
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }

                // Save the user session in the cache
                session = SaveSessionInCache(user, uti, _rizecache);

                // The impersonation validation is not necessary for the first login
                performImpersonationCheck = false;
            }

            if (performImpersonationCheck)
            {
                if (session.User.EmailAddress.ToLower() != email.ToLower())
                    throw new System.UnauthorizedAccessException("Unauthorized");
            }

            // TODO: Check if the user has the right permissions to access the controller and action

            // Continue executing the action
            await next();
        }

        private SessionVM SaveSessionInCache(UserDTO user, string uti, IRizeCacheService rizeCacheService)
        {
            // TODO: Find the roles and privileges of the user

            // Save the user session in the cache
            SessionVM session = new();
            session.User = new UserVM()
            {
                Id = user.UserId,
                IdentityId = user.RowGuid,
                EmailAddress = user.EmailAddress,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LastLoginDate = user.LastLogin == null ? DateTime.Now : Convert.ToDateTime(user.LastLogin),
                UserName = user.Username,
                UserStatusId = user.IsActive.ToString(),
                UserStatusName = user.IsActive ? "Active" : "Inactive",
                IsDeleted = user.IsActive,
                UserRoles = new List<UserRoleVM>(),
                UserGroups = new List<UserGroupVM>(),
            };
            session.UserPermissions = new UserProjectPermissionsVM();

            rizeCacheService.SetCacheKey($"Session_{uti}", session);
            return session;
        }
    }

}
