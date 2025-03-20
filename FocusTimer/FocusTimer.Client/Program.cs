using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// add MudBlazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();
