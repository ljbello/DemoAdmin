using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Rize.Admin.Data.DataServices;
using Rize.Admin.Data.DataServices.Interfaces;
using Rize.Admin.Services.Interface;
using Rize.Admin.Services.MicrosoftGraph.ARMAPI;
using Rize.Admin.Services.MicrosoftGraph.Rest;
using Rize.Admin.Services.Services;
using Rize.Cache.Internal;
using Rize.Middlewares;
using Rize.Model.ApplicationDBcontext;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// Add Kendo UI services to the services container.
builder.Services.AddKendo();

builder.Services.AddDbContext<CDEntities>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
                 .EnableSensitiveDataLogging()  // Enables detailed logging
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information), ServiceLifetime.Transient);


// Add Microsoft Identity Platform
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
   .AddMicrosoftIdentityWebApp(configuration.GetSection("AzureAd"))
   .EnableTokenAcquisitionToCallDownstreamApi()
    .AddInMemoryTokenCaches();

// Add APIs for Microsoft Graph
builder.Services.AddGraphService(configuration);
builder.Services.AddHttpClient<IArmOperations, ArmApiOperationService>();
builder.Services.AddHttpClient<IArmOperationsWithImplicitAuth, ArmApiOperationServiceWithImplicitAuth>()
    .AddMicrosoftIdentityUserAuthenticationHandler(
"arm",
        options => options.Scopes = $"{ArmApiOperationService.ArmResource}user_impersonation");

builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
}).AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null)
.AddMicrosoftIdentityUI();

//DataServices
builder.Services.AddScoped<IStoreDS, StoreDS>();
builder.Services.AddScoped<IAccountDS, AccountDS>();
builder.Services.AddScoped<IUserDS, UserDS>();
builder.Services.AddScoped<IStoreProceduresDS, StoreProceduresDS>();


//Services
builder.Services.AddScoped<IStoreService, StoreService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddHttpContextAccessor();

builder.Services.InitializeLocalCache();



//builder.Services.InitializeRizeRedisCache("RIZE.ADMINTEST","LOCALENV", "ADMIN");




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePages(async context =>
{
    var response = context.HttpContext.Response;

    if (response.StatusCode == 404)
    {
        response.Redirect("/Home/NotFound");
    }
    else if (response.StatusCode == 500)
    {
        // For 500 errors, you can pass a message to your error page
        response.Redirect("/Home/Error?message=An unexpected error occurred.");
    }
});


app.UseExceptionMiddleware();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
