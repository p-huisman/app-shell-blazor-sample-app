using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CatalogApp;
using CatalogApp.Models;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.RegisterCustomElement<App>("catalog-app");

builder.Services.AddFluentUIComponents();

builder.Services.AddSingleton<RobotCatalog>();

 
builder.Services.AddScoped(
    sp => new HttpClient 
    { 
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    }
);


await builder.Build().RunAsync();
