using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CatalogApp;
using CatalogApp.Models;
using Microsoft.FluentUI.AspNetCore.Components;
//
var builder = WebAssemblyHostBuilder.CreateDefault(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:9090");
        });
});

builder.RootComponents.RegisterCustomElement<App>("my-app");

builder.Services.AddFluentUIComponents();

builder.Services.AddSingleton<RobotCatalog>();

builder.Services.AddScoped(
    sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }
);


await builder.Build().RunAsync();
