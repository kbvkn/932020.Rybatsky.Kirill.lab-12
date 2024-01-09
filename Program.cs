//using _931920.tikhomirov.ilya.lab12.Models;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();