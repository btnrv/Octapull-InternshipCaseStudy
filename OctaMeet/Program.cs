using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OctaMeet.Areas.Identity.Data;
using OctaMeet.Data;
using OctaMeet.FileUpload;
using OctaMeet.Models;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("OctaMeetDbContextConnection") ?? throw new InvalidOperationException("Connection string 'OctaMeetDbContextConnection' not found.");

builder.Services.AddDbContext<OctaMeetDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<MeetingDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<OctaMeetUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<OctaMeetDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddScoped<Interface, LocalFile>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
