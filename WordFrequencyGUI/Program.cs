using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WordFrequencyGUI;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string baseUrl = "https://wordfrequencyapi20230707193303.azurewebsites.net/";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl)});

await builder.Build().RunAsync();
