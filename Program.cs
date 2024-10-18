using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TransactionWeb;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add this
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7173/") });
builder.Services.AddSingleton<TransactionPackage.Business>();


await builder.Build().RunAsync();
