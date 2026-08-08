using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Repositories;
using Service;
using UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Entity Framework + PostgreSQL
builder.Services.AddDbContext<PremierLeagueContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Dependency Injection
builder.Services.AddScoped<EquiposRepository>();
builder.Services.AddScoped<EquipoService>();

// Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);

    // The default HSTS value is 30 days.
    // You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();