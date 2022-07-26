using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using FinalProject.Blazor.Data;
using FinalProjectApiCli.Model;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
var builder = WebApplication.CreateBuilder(args);
Configuration config = new Configuration() {BasePath = "http://localhost:5176"};
var apiInstance = new MyDayApi(config);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
