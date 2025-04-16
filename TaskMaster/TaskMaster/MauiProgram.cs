using Microsoft.EntityFrameworkCore;
using TaskMaster.Data;
using TaskMaster;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>() // Associe l'application à la classe App
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Configuration de la base de données
        var connectionString = "server=localhost;port=3306;user=root;password=;database=taskmasterdb;";
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        // Crée l'application
        var app = builder.Build();

        // Vérifie la connexion à la base de données
        EnsureDatabaseCreated(connectionString);

        return app;
    }

    private static void EnsureDatabaseCreated(string connectionString)
    {
        try
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .Options;

            using var context = new AppDbContext(options);
            if (context.Database.EnsureCreated())
            {
                Console.WriteLine("Base de données créée avec succès.");
            }
            else
            {
                Console.WriteLine("La base de données existe déjà.");
            }

            // Vérification des tables
            var tables = context.Database.ExecuteSqlRaw("SHOW TABLES;");
            Console.WriteLine($"Tables dans la base de données : {tables}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur lors de la connexion à la base de données : {ex.Message}");
        }
    }

}
