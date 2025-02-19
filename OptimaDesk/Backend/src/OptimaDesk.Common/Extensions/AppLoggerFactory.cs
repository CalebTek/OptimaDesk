using Microsoft.Extensions.Logging;

namespace OptimaDesk.Common.Extensions
{
    public static class AppLoggerFactory
    {
        private static ILoggerFactory _loggerFactory;

        public static void Configure(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public static ILogger CreateLogger<T>() => _loggerFactory.CreateLogger<T>();
    }
}
