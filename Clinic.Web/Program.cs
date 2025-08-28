using System.Globalization;
using Clinic.Common;
using Clinic.Infrastructure.Data;
using Clinic.Infrastructure.Persistence;
using Clinic.Web.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services; // <-- Add this
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// --- Add this block to set the culture for Sri Lanka ---
var cultureInfo = new CultureInfo("en-LK"); // English - Sri Lanka
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
// ----------------------------------------------------

var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ??
                       throw new InvalidOperationException(
                           "Connection string 'ApplicationDbContextConnection' not found.");
builder.Services.AddDbContext<ClinicDbContext>(options => options.UseSqlite(connectionString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ClinicDbContext>();

builder.Services.AddRazorPages();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// This single line registers all necessary Radzen services (Dialog, Notification, etc.)
builder.Services.AddRadzenComponents();

// This is for the authentication state
builder.Services.AddCascadingAuthenticationState();


// ✅ Fix: Register a dummy IEmailSender so Identity can resolve it
builder.Services.AddTransient<IEmailSender, DummyEmailSender>();


var app = builder.Build();

// Seed the data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await DbInitializer.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapRazorPages();

app.Run();


// -----------------
// Dummy EmailSender
// -----------------
public class DummyEmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        Console.WriteLine($"[EmailSender] To: {email}, Subject: {subject}, Message: {htmlMessage}");
        return Task.CompletedTask;
    }
}
