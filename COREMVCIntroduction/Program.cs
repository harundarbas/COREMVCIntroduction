//Add services here

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


//Configure servicves here(Configure Pipeline)
WebApplication app = builder.Build();

app.UseRouting();

//app.MapDefaultControllerRoute(); //Home/Index

//Category/CategoryList
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Deneme}/{action=Index}/{id?}"
    );

app.Run();
