using System.Globalization;
using ExampleApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleApp;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

        builder.Services.AddRazorPages();
        builder.Services.AddTransient<ProductRepository>();

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseStatusCodePages();
        app.UseRouting();

        app.UseAuthorization();
        app.MapRazorPages();

        app.Run();
    }
}