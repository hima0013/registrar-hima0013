using Microsoft.EntityFrameworkCore;
using registrar_hima0013.Components; // <- Corrected!
using registrar_hima0013.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Database context configuration
builder.Services.AddDbContext<RegistrarContext>(options =>
    options.UseSqlite("Data Source=Data/Registrar.sqlite"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
