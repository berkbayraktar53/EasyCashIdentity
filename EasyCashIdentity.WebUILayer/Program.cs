using Autofac;
using NToastNotify;
using EasyCashIdentity.WebUILayer.Models;
using EasyCashIdentity.EntityLayer.Concrete;
using Autofac.Extensions.DependencyInjection;
using EasyCashIdentity.BusinessLayer.DependencyResolvers.Autofac;
using EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework.Contexts;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
#region NToastNotify implementation
builder.Services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
{
    TimeOut = 5000,
    ProgressBar = true,
    PositionClass = ToastPositions.TopRight,
});
#endregion
#region Autofac implementation
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new BusinessModule()));
#endregion
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<DatabaseContext>().AddErrorDescriber<CustomIdentityValidator>();
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();