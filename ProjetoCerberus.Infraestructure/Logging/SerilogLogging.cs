using Serilog;

namespace ProjetoCerberus.Infrastructure.Logging
{
    public static class SerilogLogging
    {
        public static void ConfigureLogging(string logFilePath)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logFilePath)
                .CreateLogger();
        }
    }
}