using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WordFrequencyGUI;
using BlazorBootstrap;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


string baseUrl = "https://localhost:7272";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl) });

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
