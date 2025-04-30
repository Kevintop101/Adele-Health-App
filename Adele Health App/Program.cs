using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Adele_Health_App.Areas.Identity.Data;
using Adele_Health_App.Models;
using Microsoft.AspNetCore.Authentication.Google;

var builder = WebApplication.CreateBuilder(args);

// Identity / Auth DB connection string
var identityConnectionString = builder.Configuration.GetConnectionString("AdeleHealthAppAuthConnection")
    ?? throw new InvalidOperationException("Connection string 'AdeleHealthAppAuthConnection' not found.");

// Application (logging/lifestyle) DB connection string
var appDbConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<AdeleHealthAppAuth>(options =>
    options.UseSqlServer(identityConnectionString));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(appDbConnectionString));

builder.Services.AddDefaultIdentity<AdeleHealthAppUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AdeleHealthAppAuth>();

// Google auth config
builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = builder.Configuration["GoogleKeys:ClientID"];
        googleOptions.ClientSecret = builder.Configuration["GoogleKeys:ClientSecret"];
    });

builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddControllers(); 

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); 
app.UseAuthorization();

app.MapRazorPages();

app.Run();

