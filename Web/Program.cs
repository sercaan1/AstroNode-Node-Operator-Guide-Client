using Business.Profiles;
using Microsoft.Extensions.DependencyInjection;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string uri = builder.Configuration.GetValue<string>("ReplicaAPI");
builder.Services.AddHttpClient("ReplicaAPI", HttpClient =>
{
    HttpClient.BaseAddress = new Uri(uri);
});

builder.Services.AddAutoMapper(typeof(IProfile).Assembly);

builder.Services.AddBusinessServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
