using BlazorStrap;
using BugTrackerCP;
using BugTrackerCP.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorStrap();

builder.Services.AddTransient<IBugsService, BugsService>();
builder.Services.AddTransient<IAssigneesService, AssigneesService>();

await builder.Build().RunAsync();
