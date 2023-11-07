using System.Globalization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

namespace YetgenAkbankJump.BlazorDI.Extensions
{
    public static class WebAssemblyHostExtension
    {
        public static async Task SetDefaultCulture(this WebAssemblyHost host)
        {
            var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
            var result = await jsInterop.InvokeAsync<string>("blazorCulture.get");
            CultureInfo culture;
            if (!string.IsNullOrEmpty(result))
                culture = new CultureInfo(result);
            else
                culture = new CultureInfo("tr-TR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}
