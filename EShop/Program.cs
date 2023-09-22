
using Eshop.Domain.core.AppService;
using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Entities;
using Eshop.Domain.core.IServices.FileService;
using Eshop.Domain.core.IServices.PictureService.Commands;
using Eshop.Domain.core.IServices.PictureService.Queries;
using Eshop.Domain.Services.PictureService.Queries;
using Eshop.Infra.Data.Repos.Ef;
using Eshop.Infra.Db_SqlServer.EF;
using EShop.Domain.AppServices.CategoryAppServce;
using EShop.Domain.AppServices.ProductAppService;
using EShop.Domain.core.IServices.Authenticate;
using EShop.Domain.core.IServices.CategoryService.Command;
using EShop.Domain.core.IServices.CategoryService.Queries;
using EShop.Domain.core.IServices.CustomerService.Command;
using EShop.Domain.IRepositories;
using EShop.Domain.Services.CategoryService.Command;
using EShop.Domain.Services.CategoryService.Queries;
using EShop.Domain.Services.CustomerService.Command;
using EShop.Domain.Services.File;
using EShop.Domain.Services.PictureService.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing.Tree;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

# region Injections

# region Addmin
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
#endregion

# region AppUser ----Role
builder.Services.AddScoped<IUserManagerRepository, UserManagerRepository>();
#endregion

# region Cart
builder.Services.AddScoped<ICartRepository, CartRepository>();
#endregion

# region Category
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryQueryService, CategoryQueryService>();
builder.Services.AddScoped<ICategoryCommandService, CategoryCommandService>();
builder.Services.AddScoped<ICategoryAppServices, CategoryAppServices>();
#endregion

# region Customer
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerCommandService, CustomerCommandService>();
#endregion

# region File
builder.Services.AddScoped<IFileServices, FileServices>();
#endregion

# region Order
#endregion

# region Picture
builder.Services.AddScoped<IPictureRepository, PictureRepository>();
builder.Services.AddScoped<IPictureQueryService, PictureQueryService>();
builder.Services.AddScoped<IPictureCommandService, PictureCommandService>();
#endregion

# region Product
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductAppservices, ProductAppServices>();
#endregion

#endregion




//--DbContext
builder.Services.AddDbContext<EshopContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


# region Identity
builder.Services.AddIdentity<AppUser,AppRole>()
.AddEntityFrameworkStores<EshopContext>()
.AddRoles<AppRole>();

builder.Services.Configure<IdentityOptions>(option =>
{
    //UserSetting
    //option.User.AllowedUserNameCharacters = "abcd123";
    option.User.RequireUniqueEmail = true;

    //Password Setting
    option.Password.RequireDigit = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireNonAlphanumeric = false;//!@#$%^&*()_+
    option.Password.RequireUppercase = false;
    option.Password.RequiredLength = 4;
    option.Password.RequiredUniqueChars = 1;

    //Lokout Setting
    option.Lockout.MaxFailedAccessAttempts = 3;
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(10);

    //SignIn Setting
    option.SignIn.RequireConfirmedAccount = false;
    option.SignIn.RequireConfirmedEmail = false;
    option.SignIn.RequireConfirmedPhoneNumber = false;

});

builder.Services.ConfigureApplicationCookie(option =>
{
    // cookie setting
    option.ExpireTimeSpan = TimeSpan.FromMinutes(10);

    option.LoginPath = "/Authenticate/login";
    option.AccessDeniedPath = "/Authenticate/AccessDenied";
    option.SlidingExpiration = true;
});


// ---set Authorazation to All endpoints.
builder.Services.AddMvc(Option =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
Option.Filters.Add(new AuthorizeFilter(policy));
});

#endregion

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
name: "Admin",
pattern: "{area:exists}/{controller=Panel}/{action=Index}/{id?}");


////--------Area as default Route--------////
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{area=Admin}/{controller=Panel}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "/{controller=Home}/{action=Index}/{id?}");

app.Run();
