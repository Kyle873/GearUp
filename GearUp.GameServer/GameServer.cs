using Microsoft.AspNetCore.Server.Kestrel.Core;
using Serilog;
using Serilog.Events;
using System.Reflection;

namespace GearUp.GameServer
{
    public class GameServer
    {
        public static void Main(string[] args)
        {
            var loggerConfiguration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
                .Build();

            {
                var logFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "logs", "log.txt");
                if (File.Exists(logFilePath))
                {
                    var prevLogFilePath = Path.Combine(Path.GetDirectoryName(logFilePath)!, "log-prev.txt");
                    if (File.Exists(prevLogFilePath))
                        File.Delete(prevLogFilePath);

                    File.Move(logFilePath, prevLogFilePath);
                }
                Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logFilePath, restrictedToMinimumLevel: LogEventLevel.Verbose, shared: true)
                .ReadFrom.Configuration(loggerConfiguration)
                .CreateBootstrapLogger();
            }

            Log.Information("Starting...");
            try
            {
                var builder = WebApplication.CreateBuilder(args);
                builder.Services.Configure<KestrelServerOptions>(op => op.AllowSynchronousIO = true);
                builder.Host.UseSerilog();

                // Add services to the container.
                builder.Services.AddControllers();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                app.UseHttpsRedirection();
                app.UseAuthorization();
                app.UseSerilogRequestLogging();

                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An unhandled exception occurred during runtime");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
