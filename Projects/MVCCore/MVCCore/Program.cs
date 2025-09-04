using Microsoft.AspNetCore.Components;
using MVCCore.Api.Services;
using MVCCore.Components;

var builder = WebApplication.CreateBuilder(args);

// USED CHAT GPT TO HELP TROUBLE SHOOT AND FIX PROGRAM.CS!!!!!!!!!!!!!

// Razor Components (interactive)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Typed HttpClient for BulldogService (points at your API)
builder.Services.AddHttpClient<BulldogService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7052/"); // API port
});

// DO NOT also call AddScoped<BulldogService>()
// DO NOT also register a generic HttpClient for this scenario

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();