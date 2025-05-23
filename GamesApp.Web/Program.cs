using GamesApp.Web.Services;

namespace GamesApp.Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        // Register the GameService class as a singleton (one instance shared
        // during application lifetime) for dependency injections
        builder.Services.AddSingleton<GameService>();

        var app = builder.Build();
        app.UseStaticFiles();
        app.MapControllers();
        app.Run();
    }
}
