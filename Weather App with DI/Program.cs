using ServiceContracts;
using Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IWeatherService, WeatherService>();

WebApplication app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
