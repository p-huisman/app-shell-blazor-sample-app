using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CatalogApp;
using CatalogApp.Models;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
//
var builder = WebAssemblyHostBuilder.CreateDefault(args);



builder.RootComponents.RegisterCustomElement<App>("my-app");

builder.Services.AddFluentUIComponents();

builder.Services.AddSingleton<RobotCatalog>();

builder.Services.AddScoped(
    sp => new HttpClient(new HttpClientHandler()
    {

        // DefaultBrowserRequestCache = BrowserRequestCache.NoStore,
        //  DefaultBrowserRequestCredentials = BrowserRequestCredentials.Omit,
        // DefaultBrowserRequestMode = BrowserRequestMode.Cors,
        // BrowserRequestCredentials.Omit,
    })
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
    });

builder.Services.AddCors(policy =>
   {
       policy.AddPolicy("CorsPolicy", opt => opt
           .AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod());
   });

await builder.Build().RunAsync();
