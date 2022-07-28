using Serilog;
using Serilog.Events;

namespace DistributedCache.WebApi.Utils
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSerilog(this IHostBuilder host)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Async(wt => wt.Console(LogEventLevel.Verbose, "[{Level:u3} {Timestamp:yyyy-MM-dd HH:mm:ss}] {Message:lj}{NewLine}{Exception}"))
                .CreateLogger();

            host.UseSerilog(Log.Logger);
        }
    }
}
