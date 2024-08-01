using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlogFrontend;
using BlogFrontend.Services;
using Blazored.LocalStorage;
using BlogFrontend.Providers;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore(options =>  {});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("IdentityService", httpClient =>
{
    httpClient.BaseAddress = new Uri("http://localhost:5066/");
});
builder.Services.AddBlazoredLocalStorageAsSingleton();

await builder.Build().RunAsync();