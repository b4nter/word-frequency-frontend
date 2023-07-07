using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WordFrequencyGUI;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string baseUrl = "https://localhost:7272/";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl)});

await builder.Build().RunAsync();
