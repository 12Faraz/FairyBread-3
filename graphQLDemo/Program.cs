using graphQLDemo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Use your custom startup class instead of the default one
        var appStartup = new MyAppStartup();
        appStartup.ConfigureServices(builder.Services);

        var app = builder.Build();
        app.MapGraphQL();
        app.Run();
    }
}
