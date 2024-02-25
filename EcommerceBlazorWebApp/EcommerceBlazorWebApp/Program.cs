global using EcommerceBlazorShared.Models;
global using EcommerceBlazorWebApp.Helpers;
global using EcommerceBlazorWebApp.Services.RequestProvider;
global using EcommerceBlazorWebApp.Services.CategoryService;
global using EcommerceBlazorWebApp.Services.ProductService;
using EcommerceBlazorWebApp.Components;



var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped<IHttpRequestProvider, HttpRequestProvider>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();
//app.UseStatusCodePagesWithRedirects("/error/{0}");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(EcommerceBlazorWebApp.Client._Imports).Assembly);

app.Run();
