using ApiEnd.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);


/*builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddDbContext<AllContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



builder.Services.AddRazorPages().AddMicrosoftIdentityUI();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages();    

app.Run();*/

var azureAdSection = builder.Configuration.GetSection("AzureAd");
if (azureAdSection == null)
{
    Console.WriteLine("AzureAd section is not found in the configuration.");
    //Environment.Exit(1); // Stop the application
}

var tenantId = azureAdSection["TenantId"];
var clientId = azureAdSection["ClientId"];
var instance = azureAdSection["Instance"];

Console.WriteLine($"TENANTID ===> {tenantId}");
Console.WriteLine($"CLIENTID ===> {clientId}");
Console.WriteLine($"INSTANCE ===> {instance}");

if (string.IsNullOrWhiteSpace(tenantId) || string.IsNullOrWhiteSpace(clientId) || string.IsNullOrWhiteSpace(instance))
{
    Console.WriteLine("Azure AD configuration is invalid. Application will stop.");
    //Environment.Exit(1); // Stop the application
}

builder.Services.AddDbContext<AllContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
builder.Services.AddRazorPages().AddMicrosoftIdentityUI();

// Configure authorization policies
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequiredScope", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("scp", builder.Configuration["AzureAd:Scopes"]);
    });

    options.AddPolicy("AdminPolicy", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("roles", "admin");
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
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

app.MapControllers();
app.MapRazorPages();

app.Run();

bool TestAzureAdAuthentication(string tenantId, string clientId, string instance)
{
    return true;
}
