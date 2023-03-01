using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazor_Grid_Demo_App_Blazor_Server;
using Blazor_Grid_Demo_App_Blazor_Server.AutoUsers;
using Blazor_Grid_Demo_App_Blazor_Server.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


builder.Services.AddScoped<IAutoUsersService>(sp => new AutoUsersService(new HttpClient()));
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(sp.GetRequiredService<IWebHostEnvironment>()));
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbGridModule),
        typeof(IgbTabsModule),
        typeof(IgbDataGridToolbarModule)
    );
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
