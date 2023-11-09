using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Sotsera.Blazor.Toaster.Core.Models;
using System.Globalization;
using System.Text.RegularExpressions;
using YetgenAkbankJump.BlazorDI;
using YetgenAkbankJump.BlazorDI.Extensions;
using YetgenAkbankJump.BlazorDI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IToasterService, SotseraToastService>();

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

// Add the library to the DI system
builder.Services.AddToaster(config =>
{
    //example customizations
    config.PositionClass = Defaults.Classes.Position.TopRight;
    config.PreventDuplicates = true;
    config.NewestOnTop = false;
});
//var trCulture = new CultureInfo("tr-TR");

//CultureInfo.DefaultThreadCurrentCulture = trCulture;
//CultureInfo.DefaultThreadCurrentUICulture = trCulture;

var host = builder.Build();

await host.SetDefaultCulture();

await host.RunAsync();
