using Microsoft.Extensions.Logging;
using Soenneker.Extensions.DateTime;

namespace Soenneker.Extensions.Logger;

/// <summary>
/// A collection of helpful ILogger extension methods
/// </summary>
public static class LoggerExtension
{
    public static void LogStartupInformation(this ILogger logger, System.TimeZoneInfo timeZoneInfo)
    {
        logger.LogDebug("----- Startup information -----");

        logger.LogDebug("Current time: {time} ET", System.DateTime.UtcNow.ToTz(timeZoneInfo).ToPreciseFormat());

        logger.LogDebug("----- /Startup information -----");
    }
}