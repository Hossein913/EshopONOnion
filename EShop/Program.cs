
using Eshop.Domain.Entities;
using Eshop.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing.Tree;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddInfrastructure();


//--DbContext
builder.Services.AddDbContext<EshopContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


# region Identity
//builder.Services.AddIdentity<AppUser,AppRole>()
//.AddEntityFrameworkStores<EshopContext>()
//.AddRoles<AppRole>();

//builder.Services.Configure<IdentityOptions>(option =>
//{
//    //UserSetting
//    //option.User.AllowedUserNameCharacters = "abcd123";
//    option.User.RequireUniqueEmail = true;

//    //Password Setting
//    option.Password.RequireDigit = false;
//    option.Password.RequireLowercase = false;
//    option.Password.RequireNonAlphanumeric = false;//!@#$%^&*()_+
//    option.Password.RequireUppercase = false;
//    option.Password.RequiredLength = 4;
//    option.Password.RequiredUniqueChars = 1;

//    //Lokout Setting
//    option.Lockout.MaxFailedAccessAttempts = 3;
//    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(10);

//    //SignIn Setting
//    option.SignIn.RequireConfirmedAccount = false;
//    option.SignIn.RequireConfirmedEmail = false;
//    option.SignIn.RequireConfirmedPhoneNumber = false;

//});

//builder.Services.ConfigureApplicationCookie(option =>
//{
//    // cookie setting
//    option.ExpireTimeSpan = TimeSpan.FromMinutes(10);

//    option.LoginPath = "/Authenticate/login";
//    option.AccessDeniedPath = "/Authenticate/AccessDenied";
//    option.SlidingExpiration = true;
//});


//// ---set Authorazation to All endpoints.
//builder.Services.AddMvc(Option =>
//{
//    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
//Option.Filters.Add(new AuthorizeFilter(policy));
//});

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
