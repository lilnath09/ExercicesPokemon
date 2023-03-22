using ExercicePokemon.Models;
using Microsoft.AspNetCore.Builder;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args); // Cr�e une web app avec les param�tres envoy�s
        builder.Services.AddControllersWithViews(); // Permet MVC
        builder.Services.AddRazorPages(); // Permet utilisation de Razor
        builder.Services.AddSingleton<BaseDeDonnees>();




        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = context => context.Context.Response.Headers.Add("Cache-Control", "no-cache")
            });
        }
        else
        {
            app.UseStaticFiles();
        }


        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id?}",
                defaults: new { controller = "Pokemon", action = "Lister" });
        });

        app.MapRazorPages();
        app.Run();
    }
}

// Doc
// Environnements: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-7.0
// Fichiers statiques et wwwroot : https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-7.0
// Gestion de la cache : https://learn.microsoft.com/en-us/aspnet/core/performance/caching/response?view=aspnetcore-7.0