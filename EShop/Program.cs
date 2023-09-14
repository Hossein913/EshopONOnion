using EShop.Data;
using EShop.Data.Repository;
using EShop.Data.Services.Authenticate;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.Authenticate;
using EShop.Domain.IServices.CategoryService.Queries;
using EShop.Domain.IServices.CustomerService.Command;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing.Tree;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//------Add Repositores
builder.Services.AddScoped<ICartRepository,CartRepository>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
builder.Services.AddScoped<IPictureRepository,PictureRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IUserManagerRepository, UserManagerRepository>();

//------Add Services
builder.Services.AddScoped<ICategoryQueryService, CategoryQueryService>();
builder.Services.AddScoped<IAuthenticateService, AuthenticateService>();
builder.Services.AddScoped<ICustomerCommandService, CustomerCommandService>();

//-- DbContext
builder.Services.AddDbContext<EshopContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//-- Identity
builder.Services.AddIdentity<User,Role>()
.AddEntityFrameworkStores<EshopContext>()
.AddRoles<Role>();

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
pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
