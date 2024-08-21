using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlogFrontend;
using BlogFrontend.Services;
using Blazored.LocalStorage;
using BlogFrontend.Providers;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<JwtAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<JwtAuthenticationStateProvider>());

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://20.218.163.172") });
builder.Services.AddScoped<TopicService>();
builder.Services.AddScoped<BlogService>();

builder.Services.AddSingleton(new JsonSerializerOptions
{
    ReferenceHandler = ReferenceHandler.Preserve
});

builder.Services.AddHttpClient("IdentityService", httpClient =>
{
    httpClient.BaseAddress = new Uri("http://20.218.163.172");
    httpClient.BaseAddress = new Uri("http://135.236.156.195");
});
builder.Services.AddBlazoredLocalStorageAsSingleton();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();